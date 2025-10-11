using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpVoronoiLib;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace MonoGameExample;

public class VoronoiGame : Game
{
    private readonly Color _backgroundColor = new Color(147, 145, 133);
    
    private readonly Color _lineColor = new Color(47, 54, 69);
    private readonly Color _hoveredLineColor = new Color(240, 24, 222);

    /// <summary> Margin from viewport edge so we can preview the voronoi edges </summary>
    private const int edgeDistance = 15;

    // Tooltip styling
    private readonly Color _tooltipBackgroundColor = new Color(20, 20, 20, 200);
    private readonly Color _tooltipTextColor = new Color(230, 230, 230, 255);

    
    private readonly GraphicsDeviceManager _graphics;

    private SpriteBatch _spriteBatch;
    private SpriteFont _font;
    
    private Texture2D _pixelTexture;

    private KeyboardState _lastKeyboardState;

    private VoronoiPlane _plane;

    private VoronoiSite _hoveredSite;


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
        _font = Content.Load<SpriteFont>("DefaultFont");
    }

    protected override void Update(GameTime gameTime)
    {
        KeyboardState keyboardState = Keyboard.GetState();
        
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || keyboardState.IsKeyDown(Keys.Escape))
            Exit();

        if (GraphicsDevice.Viewport.Width != ((int)(_plane.MaxX - _plane.MinX) + edgeDistance * 2) ||
            GraphicsDevice.Viewport.Height != ((int)(_plane.MaxY - _plane.MinY) + edgeDistance * 2))
            Generate();
        
        if (keyboardState.IsKeyDown(Keys.Space) && _lastKeyboardState.IsKeyUp(Keys.Space))
            Generate();

        _lastKeyboardState = keyboardState;
        
        MouseState mouseState = Mouse.GetState();
        
        _hoveredSite = _plane.GetNearestSiteTo(mouseState.X - edgeDistance, mouseState.Y - edgeDistance);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(_backgroundColor);

        _spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointWrap);

        foreach (VoronoiEdge edge in _plane.Edges!)
        {
            Vector2 start = new Vector2((float)edge.Start.X + edgeDistance, (float)edge.Start.Y + edgeDistance);
            Vector2 end = new Vector2((float)edge.End.X + edgeDistance, (float)edge.End.Y + edgeDistance);
            
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
        
        float width = 0f;
        float height = 0f;

        for (int i = 0; i < lines.Count; i++)
        {
            Vector2 size = _font.MeasureString(lines[i]);
            if (size.X > width) width = size.X;
            height += i == lines.Count - 1 ? size.Y : _font.LineSpacing;
        }
        
        // Get position

        MouseState mouse = Mouse.GetState();
        Vector2 pos = new Vector2(mouse.X + 14, mouse.Y + 16);

        // Clamp within viewport

        const int paddingHor = 4;
        const int paddingVer = 1; // < hor because font already "pad" as vertical spacing basically

        int vpW = GraphicsDevice.Viewport.Width;
        int vpH = GraphicsDevice.Viewport.Height;
        float boxW = width + paddingHor * 2;
        float boxH = height + paddingVer * 2;

        if (pos.X + boxW > vpW - 2) pos.X = vpW - 2 - boxW;
        if (pos.Y + boxH > vpH - 2) pos.Y = vpH - 2 - boxH;
        if (pos.X < 2) pos.X = 2;
        if (pos.Y < 2) pos.Y = 2;

        // Background
        
        Rectangle rectangle = new Rectangle((int)pos.X, (int)pos.Y, (int)boxW, (int)boxH);
        _spriteBatch.Draw(_pixelTexture, rectangle, _tooltipBackgroundColor);

        // Text
        
        Vector2 textPos = new Vector2(pos.X + paddingHor, pos.Y + paddingVer);
        for (int i = 0; i < lines.Count; i++)
        {
            _spriteBatch.DrawString(_font, lines[i], textPos, _tooltipTextColor);
            textPos.Y += i == lines.Count - 1 ? _font.MeasureString(lines[i]).Y : _font.LineSpacing;
        }
    }
    
    private void Generate()
    {
        //List<VoronoiSite>? sites = MakeRandomSites()
        List<VoronoiSite>? sites = LoadDebugSites(out float minX, out float minY, out float maxX, out float maxY);

        if (sites == null) return; // prevent exception
        
        _plane = new VoronoiPlane(minX, minY, maxX, maxY);
        
        _plane.SetSites(sites);
        
        _plane.Tessellate();
        
        _plane.Relax();
    }


    private List<VoronoiSite>? LoadDebugSites(out float minX, out float minY, out float maxX, out float maxY)
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
    
    private List<VoronoiSite>? MakeRandomSites(out float minX, out float minY, out float maxX, out float maxY)
    {
        // Set to current screen
        int width = GraphicsDevice.Viewport.Width - (edgeDistance * 2);
        int height = GraphicsDevice.Viewport.Height - (edgeDistance * 2);
        
        if (width <= 0 || height <= 0) // prevent exception
        {
            minX = 0;
            minY = 0;
            maxX = 0;
            maxY = 0;
            return null!;
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
}