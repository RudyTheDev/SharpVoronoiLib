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
    private readonly Color _selectedLineColor = new Color(255, 196, 0);
    private readonly Color _selectedNeighbouringLineColor = new Color(255, 140, 0);

    /// <summary> Small margin from viewport edge to not have the map right at the edge </summary>
    private const int viewportMargin = 15;

    // Zoom configuration
    private const float minZoom = 0.2f;
    private const float maxZoom = 10.0f;
    private const float zoomStep = 1.3f; // per wheel notch

    // Click vs drag threshold
    private const int dragThreshold = 5; // px

    // Tooltip styling
    private readonly Color _tooltipBackgroundColor = new Color(20, 20, 20, 200);
    private readonly Color _tooltipTextColor = new Color(230, 230, 230, 255);

    
    private readonly GraphicsDeviceManager _graphics;

    private SpriteBatch _spriteBatch = null!;
    
    private SpriteFontBase _font = null!;
    
    private Texture2D _pixelTexture = null!;

    private KeyboardState _lastKeyboardState;
    private MouseState _lastMouseState;

    private VoronoiPlane _plane = null!;

    private VoronoiSite? _hoveredSite;
    private VoronoiSite? _selectedSite;

    // Track whether mouse is inside the world bounds for tooltip display
    private bool _isMouseInsideWorld;

    // Camera state (world center and zoom). Zoom is a multiplier over the fit-to-view scale.
    private double _cameraCenterX;
    private double _cameraCenterY;
    private float _cameraZoom = 1.0f;

    // Cached transform for current frame
    private float _fitScale; // scale to fit world inside (viewport - margins)
    private float _scale;
    private float _screenCenterX;
    private float _screenCenterY;

    // Encapsulated mouse interaction state
    private InteractionState _interactionState = new IdleState();


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
        _lastMouseState = Mouse.GetState();
        
        Generate();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // Font
        
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
        MouseState mouseState = Mouse.GetState();

        // Ignore all input if the window is not active/focused (anymore)
        if (!IsActive)
        {
            // Clear any ongoing interaction state
            if (_interactionState is not IdleState)
                _interactionState = new IdleState();
            _isMouseInsideWorld = false;
            _lastKeyboardState = keyboardState;
            _lastMouseState = mouseState;
            
            base.Update(gameTime);
            return;
        }
        
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || keyboardState.IsKeyDown(Keys.Escape))
            Exit();

        // Press Space to (re)generate and reset camera
        if (keyboardState.IsKeyDown(Keys.Space) && _lastKeyboardState.IsKeyUp(Keys.Space))
            Generate();

        // Recalculate transform at the start of the frame (accounts for resize)
        RecalculateTransform();

        // Determine if mouse is within the current viewport bounds
        int viewportWidth = GraphicsDevice.Viewport.Width;
        int viewportHeight = GraphicsDevice.Viewport.Height;
        bool isMouseInsideViewport = mouseState.X >= 0 && mouseState.Y >= 0 && mouseState.X < viewportWidth && mouseState.Y < viewportHeight;

        // Handle zoom via mouse wheel, keeping the world point under cursor stationary
        int wheelDelta = mouseState.ScrollWheelValue - _lastMouseState.ScrollWheelValue;
        if (wheelDelta != 0 && isMouseInsideViewport)
        {
            float notches = wheelDelta / 120.0f;
            float factor = (float)Math.Pow(zoomStep, notches);

            Vector2 worldBefore = ScreenToWorld(mouseState.X, mouseState.Y);

            _cameraZoom *= factor;
            _cameraZoom = Math.Clamp(_cameraZoom, minZoom, maxZoom);

            RecalculateTransform();
            
            Vector2 worldAfter = ScreenToWorld(mouseState.X, mouseState.Y);

            // Adjust center so cursor stays anchored to the same world point
            _cameraCenterX += worldBefore.X - worldAfter.X;
            _cameraCenterY += worldBefore.Y - worldAfter.Y;

            RecalculateTransform();
        }

        // Mouse interaction
        switch (_interactionState)
        {
            case IdleState:
                if (mouseState.LeftButton == ButtonState.Pressed && _lastMouseState.LeftButton == ButtonState.Released && isMouseInsideViewport)
                    _interactionState = new PressedState(mouseState.X, mouseState.Y);
                break;

            case PressedState pressed:
                if (mouseState.LeftButton == ButtonState.Released && _lastMouseState.LeftButton == ButtonState.Pressed)
                {
                    if (isMouseInsideViewport)
                        SelectNearestSiteUnder(mouseState.X, mouseState.Y);
                    _interactionState = new IdleState();
                }
                else
                {
                    int totalDx = mouseState.X - pressed.StartX;
                    int totalDy = mouseState.Y - pressed.StartY;
                    int distSq = totalDx * totalDx + totalDy * totalDy;
                    
                    if (distSq >= dragThreshold * dragThreshold)
                        _interactionState = new DraggingState(mouseState.X, mouseState.Y);
                }
                break;

            case DraggingState dragging:
                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    int dx = mouseState.X - dragging.LastX;
                    int dy = mouseState.Y - dragging.LastY;
                    if (dx != 0 || dy != 0)
                    {
                        _cameraCenterX -= dx / _scale;
                        _cameraCenterY -= dy / _scale;
                        
                        RecalculateTransform();
                        
                        _interactionState = new DraggingState(mouseState.X, mouseState.Y);
                    }
                }
                else if (mouseState.LeftButton == ButtonState.Released && _lastMouseState.LeftButton == ButtonState.Pressed)
                {
                    _interactionState = new IdleState();
                }
                break;
        }
        
        // Convert mouse screen position to world coordinates and update hover/selection state
        if (isMouseInsideViewport)
        {
            Vector2 world = ScreenToWorld(mouseState.X, mouseState.Y);
            // Track if mouse is inside world bounds for tooltip control
            _isMouseInsideWorld = world.X >= _plane.MinX && world.X <= _plane.MaxX && world.Y >= _plane.MinY && world.Y <= _plane.MaxY;
            
            _hoveredSite = _plane.GetNearestSiteTo(world.X, world.Y);
        }
        else
        {
            // Outside viewport: ignore hover and tooltip
            _isMouseInsideWorld = false;
            _hoveredSite = null;
        }

        _lastKeyboardState = keyboardState;
        _lastMouseState = mouseState;

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(_backgroundColor);

        _spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointWrap);

        // Draw edges using current camera transform (center + zoom)
        foreach (VoronoiEdge edge in _plane.Edges!)
        {
            float sx1 = _screenCenterX + (float)((edge.Start.X - _cameraCenterX) * _scale);
            float sy1 = _screenCenterY + (float)((edge.Start.Y - _cameraCenterY) * _scale);
            float sx2 = _screenCenterX + (float)((edge.End.X   - _cameraCenterX) * _scale);
            float sy2 = _screenCenterY + (float)((edge.End.Y   - _cameraCenterY) * _scale);

            Vector2 start = new Vector2(sx1, sy1);
            Vector2 end = new Vector2(sx2, sy2);
            
            float dist = Vector2.Distance(start, end);
            float rotation = (float)Math.Atan2(end.Y - start.Y, end.X - start.X);

            bool isHoveredEdge = _isMouseInsideWorld && _hoveredSite != null && (edge.Left == _hoveredSite || edge.Right == _hoveredSite);
            bool isSelectedEdge = _selectedSite != null && (edge.Left == _selectedSite || edge.Right == _selectedSite);
            bool isSelectionNeighbouringEdge = _selectedSite != null && (_selectedSite.Neighbours.Contains(edge.Left) || _selectedSite.Neighbours.Contains(edge.Right));

            Color lineColor = _lineColor;
            float lineThickness = 1f; // without anti-aliasing this won't look good no matter what, so stick to 1 pixel

            if (isSelectedEdge)
                lineThickness = 3.0f;
            else if (isHoveredEdge)
                lineThickness = 1.5f;

            if (isHoveredEdge)
                lineColor = _hoveredLineColor;
            else if (isSelectedEdge)
                lineColor = _selectedLineColor;
            else if (isSelectionNeighbouringEdge)
                lineColor = _selectedNeighbouringLineColor;
            
            _spriteBatch.Draw(
                _pixelTexture,
                start,
                null,
                lineColor,
                rotation,
                Vector2.Zero,
                new Vector2(dist, lineThickness),
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
        Dictionary<VoronoiPoint, char> pointLabels = _hoveredSite!.Points
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
        //List<VoronoiSite> sites = MakeRandomSites(out float minX, out float minY, out float maxX, out float maxY);
        List<VoronoiSite> sites = LoadDebugSites(out float minX, out float minY, out float maxX, out float maxY);
        
        _plane = new VoronoiPlane(minX, minY, maxX, maxY);
        
        _plane.SetSites(sites);
        
        _plane.Tessellate();
        
        //_plane.Relax();

        // Reset camera after generating new content
        ResetCamera();
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
        int width = GraphicsDevice.Viewport.Width - viewportMargin * 2;
        int height = GraphicsDevice.Viewport.Height - viewportMargin * 2;
        
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
    /// Recalculates camera transform based on current viewport, world bounds, and camera state.
    /// </summary>
    private void RecalculateTransform()
    {
        // World size in world units, derived from current VoronoiPlane bounds
        double worldWidth = _plane.MaxX - _plane.MinX;
        double worldHeight = _plane.MaxY - _plane.MinY;

        // Current viewport size in pixels
        int viewportWidth = GraphicsDevice.Viewport.Width;
        int viewportHeight = GraphicsDevice.Viewport.Height;
        
        // Leave a fixed margin on all sides
        double availableWidth = viewportWidth - viewportMargin * 2;
        double availableHeight = viewportHeight - viewportMargin * 2;
        // (ensure dimensions are non-zero just in case)
        if (availableWidth < 1) availableWidth = 1;
        if (availableHeight < 1) availableHeight = 1;

        // Pixels-per-world-unit along each axis if we were to fit exactly on that axis
        double scaleX = availableWidth / worldWidth;
        double scaleY = availableHeight / worldHeight;
        
        // Uniform scale that fits the world into the available area (letterbox/pillarbox as needed)
        double fit = Math.Min(scaleX, scaleY);
        if (fit <= 0.0) fit = 0.01; // numerical safety

        // Cache the fit scale and the final scale after applying the current camera zoom
        _fitScale = (float)fit; // scale that makes entire world visible inside margins at zoom = 1
        _scale = _fitScale * _cameraZoom; // final pixels-per-world-unit used for rendering
        if (_scale < 0.0001f) _scale = 0.0001f; // numerical safety

        // The screen-space center of the drawable area (inside the margins)
        _screenCenterX = viewportMargin + (float)(availableWidth * 0.5);
        _screenCenterY = viewportMargin + (float)(availableHeight * 0.5);
    }

    /// <summary>
    /// Resets camera to show the whole world, centered.
    /// </summary>
    private void ResetCamera()
    {
        _cameraCenterX = (_plane.MinX + _plane.MaxX) * 0.5;
        _cameraCenterY = (_plane.MinY + _plane.MaxY) * 0.5;
        _cameraZoom = 1.0f;
        RecalculateTransform();
    }

    /// <summary>
    /// Converts screen coordinates to world coordinates using current camera transform.
    /// </summary>
    private Vector2 ScreenToWorld(int screenX, int screenY)
    {
        float safeScale = _scale <= 0.0001f ? 0.0001f : _scale;
        float wx = (float)(_cameraCenterX + (screenX - _screenCenterX) / safeScale);
        float wy = (float)(_cameraCenterY + (screenY - _screenCenterY) / safeScale);
        return new Vector2(wx, wy);
    }

    /// <summary>
    /// Selects the nearest site under a screen-space coordinate (if any).
    /// </summary>
    private void SelectNearestSiteUnder(int screenX, int screenY)
    {
        Vector2 world = ScreenToWorld(screenX, screenY);
        _selectedSite = _plane.GetNearestSiteTo(world.X, world.Y);
    }

    
    private abstract record InteractionState;

    private sealed record IdleState : InteractionState;

    private sealed record PressedState(int StartX, int StartY) : InteractionState;

    private sealed record DraggingState(int LastX, int LastY) : InteractionState;
}
