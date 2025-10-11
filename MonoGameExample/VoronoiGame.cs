using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpVoronoiLib;
using Vector2 = Microsoft.Xna.Framework.Vector2;
using FontStashSharp;

namespace MonoGameExample;

public class VoronoiGame : Game
{
    private readonly Color _backgroundColor = new Color(147, 145, 133);
    
    private readonly Color _lineColor = new Color(47, 54, 69);
    private readonly Color _hoveredLineColor = new Color(240, 24, 222);

    /// <summary> Small margin from viewport edge to not have the map right at the edge </summary>
    private const int viewportMargin = 15;

    // Tooltip styling
    private readonly Color _tooltipBackgroundColor = new Color(20, 20, 20, 200);
    private readonly Color _tooltipTextColor = new Color(230, 230, 230, 255);

    
    private readonly GraphicsDeviceManager _graphics;

    private SpriteBatch _spriteBatch = null!;
    
    private SpriteFontBase _font = null!;
    
    private Texture2D _pixelTexture = null!;

    private KeyboardState _lastKeyboardState;

    private VoronoiPlane _plane = null!;

    private VoronoiSite _hoveredSite = null!;

    // Track whether mouse is inside the world bounds for tooltip display
    private bool _isMouseInsideWorld;


    public VoronoiGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        IsFixedTimeStep = false;
        Window.AllowUserResizing = true;
        _graphics.PreferredBackBufferWidth = 1280;
        _graphics.PreferredBackBufferHeight = 720;
        _graphics.SynchronizeWithVerticalRetrace = false;
    }

    
    protected override void Initialize()
    {
        base.Initialize();
        
        Window.Title = "SharpVoronoiLib MonoGame example"; // doesn't work in ctor
        
        _pixelTexture = new Texture2D(GraphicsDevice, 1, 1);
        _pixelTexture.SetData([ Color.White ]);
        
        _lastKeyboardState = Keyboard.GetState();
        
        Generate();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        FontSystemSettings debugFontSettings = new FontSystemSettings
        {
            PremultiplyAlpha = true,
            FontResolutionFactor = 8f,
            KernelWidth = 3,
            KernelHeight = 3
        };

        FontSystem fontSystem = new FontSystem(debugFontSettings);
        
        string appFolder = AppContext.BaseDirectory;
        
        string fontFolder = Path.Combine(appFolder, "Content");

        fontSystem.AddFont(File.ReadAllBytes(Path.Combine(fontFolder, "LiberationSans-Regular.ttf")));

        _font = fontSystem.GetFont(16);
    }

    protected override void Update(GameTime gameTime)
    {
        KeyboardState keyboardState = Keyboard.GetState();
        
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || keyboardState.IsKeyDown(Keys.Escape))
            Exit();

        if (GraphicsDevice.Viewport.Width != ((int)(_plane.MaxX - _plane.MinX) + viewportMargin * 2) ||
            GraphicsDevice.Viewport.Height != ((int)(_plane.MaxY - _plane.MinY) + viewportMargin * 2))
            Generate();
        
        if (keyboardState.IsKeyDown(Keys.Space) && _lastKeyboardState.IsKeyUp(Keys.Space))
            Generate();

        _lastKeyboardState = keyboardState;
        
        MouseState mouseState = Mouse.GetState();
        
        // Convert mouse screen position to world coordinates (inverse of Draw transform)
        float scale = ComputeScale();
        ComputeOffsets(scale, out float offsetX, out float offsetY);
        float worldX = (float)(_plane.MinX + (mouseState.X - offsetX) / Math.Max(0.0001f, scale));
        float worldY = (float)(_plane.MinY + (mouseState.Y - offsetY) / Math.Max(0.0001f, scale));
        
        // Track if mouse is inside world bounds for tooltip control
        _isMouseInsideWorld = worldX >= _plane.MinX && worldX <= _plane.MaxX && worldY >= _plane.MinY && worldY <= _plane.MaxY;
        
        _hoveredSite = _plane.GetNearestSiteTo(worldX, worldY);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(_backgroundColor);

        _spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointWrap);

        float scale = ComputeScale();
        ComputeOffsets(scale, out float offsetX, out float offsetY);
        
        foreach (VoronoiEdge edge in _plane.Edges!)
        {
            // World -> Screen transform preserving aspect ratio with fixed border and centering
            float sx1 = offsetX + (float)((edge.Start.X - _plane.MinX) * scale);
            float sy1 = offsetY + (float)((edge.Start.Y - _plane.MinY) * scale);
            float sx2 = offsetX + (float)((edge.End.X   - _plane.MinX) * scale);
            float sy2 = offsetY + (float)((edge.End.Y   - _plane.MinY) * scale);

            Vector2 start = new Vector2(sx1, sy1);
            Vector2 end = new Vector2(sx2, sy2);
            
            float dist = Vector2.Distance(start, end);
            float rotation = (float)Math.Atan2(end.Y - start.Y, end.X - start.X);

            Color lineColor = 
                edge.Left == _hoveredSite || edge.Right == _hoveredSite
                    ? _hoveredLineColor
                    : _lineColor;
            
            _spriteBatch.Draw(
                _pixelTexture,
                start,
                null,
                lineColor,
                rotation,
                Vector2.Zero,
                new Vector2(dist, 1),
                SpriteEffects.None,
                0.0f
            );
        }

        if (_isMouseInsideWorld)
            DrawTooltip(GetHoveredSiteTooltipLines());
        
        
        _spriteBatch.End();

        base.Draw(gameTime);
    }

    private IReadOnlyList<string> GetHoveredSiteTooltipLines()
    {
        // Assign labels to points (A, B, C, ...)
        Dictionary<VoronoiPoint, char> pointLabels = _hoveredSite.Points
            .Select((p, i) => new { Point = p, Label = (char)('A' + i) })
            .ToDictionary(x => x.Point, x => x.Label);

        string floatFormat = "F2";
        
        List<string> lines =
        [
            "Site " + _hoveredSite,
            "Points " + string.Join(", ", pointLabels.Select(kv => kv.Value + " " + kv.Key.ToString(floatFormat))),
            "Edges " + string.Join(", ", _hoveredSite.Cell.Select(e => pointLabels[e.Start] + "-" + pointLabels[e.End])),
            "Neighbours " + string.Join(", ", _hoveredSite.Neighbours.Select(n => n.ToString(floatFormat)))
        ];

        return lines;
    }

    private void DrawTooltip(IReadOnlyList<string> lines)
    {
        // Text measurement
        
        float tooltipWidth = 0f;
        float tooltipHeight = 0f;

        for (int i = 0; i < lines.Count; i++)
        {
            Vector2 size = _font.MeasureString(lines[i]);
            if (size.X > tooltipWidth) tooltipWidth = size.X;
            tooltipHeight += i == lines.Count - 1 ? size.Y : _font.LineHeight;
        }
        
        // Get position (near mouse)

        MouseState mouse = Mouse.GetState();
        Vector2 pos = new Vector2(mouse.X + 14, mouse.Y + 16);

        // Clamp within viewport

        const int paddingHorizontal = 4;
        const int paddingVertical = 1; // < horizontal because font already "pads" vertical spacing basically

        int viewportWidth = GraphicsDevice.Viewport.Width;
        int viewportHeight = GraphicsDevice.Viewport.Height;
        float boxWidth = tooltipWidth + paddingHorizontal * 2;
        float boxHeight = tooltipHeight + paddingVertical * 2;

        if (pos.X + boxWidth > viewportWidth - 2) pos.X = viewportWidth - 2 - boxWidth;
        if (pos.Y + boxHeight > viewportHeight - 2) pos.Y = viewportHeight - 2 - boxHeight;
        if (pos.X < 2) pos.X = 2;
        if (pos.Y < 2) pos.Y = 2;

        // Background
        
        Rectangle rectangle = new Rectangle((int)pos.X, (int)pos.Y, (int)boxWidth, (int)boxHeight);
        _spriteBatch.Draw(_pixelTexture, rectangle, _tooltipBackgroundColor);

        // Text
        
        Vector2 textPos = new Vector2(pos.X + paddingHorizontal, pos.Y + paddingVertical);
        for (int i = 0; i < lines.Count; i++)
        {
            _spriteBatch.DrawString(_font, lines[i], textPos, _tooltipTextColor);
            textPos.Y += i == lines.Count - 1 ? _font.MeasureString(lines[i]).Y : _font.LineHeight;
        }
    }
    
    private void Generate()
    {
        List<VoronoiSite> sites = MakeRandomSites(out float minX, out float minY, out float maxX, out float maxY);
        //List<VoronoiSite> sites = LoadDebugSites(out float minX, out float minY, out float maxX, out float maxY);
        
        _plane = new VoronoiPlane(minX, minY, maxX, maxY);
        
        _plane.SetSites(sites);
        
        _plane.Tessellate();
        
        _plane.Relax();
    }


    private List<VoronoiSite> LoadDebugSites(out float minX, out float minY, out float maxX, out float maxY)
    {
        string meta = File.ReadAllText("meta.txt");
        string[] metaParts = meta.Split(',');
        minX = float.Parse(metaParts[0]);
        minY = float.Parse(metaParts[1]);
        maxX = float.Parse(metaParts[2]);
        maxY = float.Parse(metaParts[3]);
        
        string[] sitesRaw = File.ReadAllLines("out.txt");
        List<VoronoiSite> sites = sitesRaw.Select(line =>
        {
            string[] parts = line.Split(',');
            return new VoronoiSite(float.Parse(parts[0]), float.Parse(parts[1]));
        }).ToList();

        return sites;
    }
    
    private List<VoronoiSite> MakeRandomSites(out float minX, out float minY, out float maxX, out float maxY)
    {
        // Set to current screen
        int width = GraphicsDevice.Viewport.Width - (viewportMargin * 2);
        int height = GraphicsDevice.Viewport.Height - (viewportMargin * 2);
        
        if (width <= 0 || height <= 0) // prevent exception
        {
            minX = 0;
            minY = 0;
            maxX = 0;
            maxY = 0;
            return [];
        }

        int numPoints = width * height / 400; // about 2000 points at 1280 x 720
        
        List<VoronoiSite> sites = new List<VoronoiSite>(numPoints);
        
        int seed = Random.Shared.Next();
        //Console.WriteLine("Seed: " + seed);
        
        Random rand = new Random(seed);
        for (int i = 0; i < numPoints; i++)
        {
            sites.Add(
                new VoronoiSite(
                    rand.Next(width), 
                    rand.Next(height)
                )
            );
        }
        
        int duplicates = Random.Shared.Next(numPoints / 20);
        
        for (int i = 0; i < duplicates; i++)
        {
            int i1 = Random.Shared.Next(numPoints);
            int i2 = Random.Shared.Next(numPoints);
            
            // "Duplicate"
            sites[i1] = new VoronoiSite(sites[i2].X, sites[i2].Y);
        }

        minX = 0;
        minY = 0;
        maxX = width;
        maxY = height;
        
        return sites;
    }


    /// <summary>
    /// Computes a uniform scale factor to fit the world rectangle (plane bounds) inside the
    /// viewport rectangle minus a fixed margin, preserving aspect ratio.
    /// </summary>
    private float ComputeScale()
    {
        // Size of the world (Voronoi plane) in world units
        double worldWidth = _plane.MaxX - _plane.MinX;
        double worldHeight = _plane.MaxY - _plane.MinY;
        if (worldWidth <= 0 || worldHeight <= 0)
            return 1f; // fallback safe value

        // Space available on screen after subtracting margins on all sides
        int viewportWidth = GraphicsDevice.Viewport.Width;
        int viewportHeight = GraphicsDevice.Viewport.Height;
        double availableWidth = Math.Max(1, viewportWidth - viewportMargin * 2);
        double availableHeight = Math.Max(1, viewportHeight - viewportMargin * 2);

        // Ratios that would map world to available area along each axis
        double scaleX = availableWidth / worldWidth;
        double scaleY = availableHeight / worldHeight;

        // We must preserve aspect ratio, so take the limiting axis
        double scale = Math.Min(scaleX, scaleY);
        
        // Clamp to a tiny positive value to avoid zero/negative or denormals
        if (scale <= 0.0) scale = 0.01;
        
        return (float)scale;
    }

    /// <summary>
    /// Computes the offset (top-left) in screen space so the world content is centered inside the
    /// available viewport area (viewport minus margins) at a given <paramref name="scale"/>.
    /// </summary>
    private void ComputeOffsets(float scale, out float offsetX, out float offsetY)
    {
        // World size in world units
        double worldWidth = _plane.MaxX - _plane.MinX;
        double worldHeight = _plane.MaxY - _plane.MinY;

        // Space available on screen after subtracting margins on all sides
        int viewportWidth = GraphicsDevice.Viewport.Width;
        int viewportHeight = GraphicsDevice.Viewport.Height;
        double availableWidth = Math.Max(1, viewportWidth - viewportMargin * 2);
        double availableHeight = Math.Max(1, viewportHeight - viewportMargin * 2);

        // How much screen space the world will occupy at the chosen scale
        double usedWidth = worldWidth * scale;
        double usedHeight = worldHeight * scale;

        // Leftover space used to center the content inside the available area
        double extraWidth = Math.Max(0.0, availableWidth - usedWidth);
        double extraHeight = Math.Max(0.0, availableHeight - usedHeight);

        // Offset includes the fixed margin plus half of the leftover area for centering
        offsetX = viewportMargin + (float)(extraWidth * 0.5);
        offsetY = viewportMargin + (float)(extraHeight * 0.5);
    }
}
