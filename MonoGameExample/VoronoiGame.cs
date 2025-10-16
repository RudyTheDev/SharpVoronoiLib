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
    
    private readonly Color _edgeColor = new Color(26, 31, 41);
    private readonly Color _hoveredLineColor = new Color(240, 24, 222);
    private readonly Color _selectedLineColor = new Color(255, 196, 0);
    private readonly Color _selectedNeighbouringLineColor = new Color(255, 140, 0);
    private readonly Color _neighbourLinkColor = new Color(133, 133, 130);
    private readonly Color _neighbourLinkColorProminent = new Color(80, 80, 78);

    /// <summary> Small margin from viewport edge to not have the map right at the edge </summary>
    private const int viewportMargin = 10;

    // Zoom configuration
    private const float minZoom = 0.2f;
    private const float maxZoom = 20.0f;
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

    private CameraTransform _cameraTransform;

    private InteractionState _interactionState = new IdleState();

    private bool _isMouseInsideWorld;

    private bool _drawEdges = true;
    private bool _drawSiteToSiteLines = true;
    
    private PointGenerationMethod _pointGenerationMethod = PointGenerationMethod.Uniform;

    private bool _showHelp = true;

    private int _relaxIterations = 1;


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
            FontResolutionFactor = 3f,
            KernelWidth = 2,
            KernelHeight = 2,
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
        
        // Keyboard interaction
        
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || keyboardState.IsKeyDown(Keys.Escape))
            Exit();
        
        if (keyboardState.IsKeyDown(Keys.D1) && _lastKeyboardState.IsKeyUp(Keys.D1))
            _drawEdges = !_drawEdges;
        
        if (keyboardState.IsKeyDown(Keys.D2) && _lastKeyboardState.IsKeyUp(Keys.D2))
            _drawSiteToSiteLines = !_drawSiteToSiteLines;

        if (keyboardState.IsKeyDown(Keys.Tab) && _lastKeyboardState.IsKeyUp(Keys.Tab))
        {
            _pointGenerationMethod = _pointGenerationMethod == PointGenerationMethod.Uniform ? PointGenerationMethod.Gaussian : PointGenerationMethod.Uniform;
            Generate();
        }

        if (keyboardState.IsKeyDown(Keys.R) && _lastKeyboardState.IsKeyUp(Keys.R))
        {
            _relaxIterations = (_relaxIterations + 1) % 3;
            Generate();
        }

        if (keyboardState.IsKeyDown(Keys.OemTilde) && _lastKeyboardState.IsKeyUp(Keys.OemTilde))
            _showHelp = !_showHelp;

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

            _cameraTransform.zoom *= factor;
            _cameraTransform.zoom = Math.Clamp(_cameraTransform.zoom, minZoom, maxZoom);

            RecalculateTransform();
            
            Vector2 worldAfter = ScreenToWorld(mouseState.X, mouseState.Y);

            // Adjust center so cursor stays anchored to the same world point
            _cameraTransform.centerX += worldBefore.X - worldAfter.X;
            _cameraTransform.centerY += worldBefore.Y - worldAfter.Y;

            RecalculateTransform();
        }

        // Mouse interaction
        
        switch (_interactionState)
        {
            case IdleState:
                if (mouseState.LeftButton == ButtonState.Pressed && _lastMouseState.LeftButton == ButtonState.Released && isMouseInsideViewport)
                    _interactionState = new PressedState(mouseState.X, mouseState.Y);

                if (mouseState.RightButton == ButtonState.Pressed && _lastMouseState.RightButton == ButtonState.Released && isMouseInsideViewport)
                    _selectedSite = null;
                break;

            case PressedState pressed:
                if (mouseState.LeftButton == ButtonState.Released && _lastMouseState.LeftButton == ButtonState.Pressed)
                {
                    if (isMouseInsideViewport)
                    {
                        Vector2 world = ScreenToWorld(mouseState.X, mouseState.Y);
                        _selectedSite = _plane.GetNearestSiteTo(world.X, world.Y);
                    }

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
                        _cameraTransform.centerX -= dx / (_cameraTransform.scale <= 0.0001f ? 0.0001f : _cameraTransform.scale);
                        _cameraTransform.centerY -= dy / (_cameraTransform.scale <= 0.0001f ? 0.0001f : _cameraTransform.scale);
                        
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
        
        // Done with inputs

        _lastKeyboardState = keyboardState;
        _lastMouseState = mouseState;

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(_backgroundColor);

        _spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointWrap);
        
        DrawOurStuff();

        _spriteBatch.End();

        base.Draw(gameTime);
    }

    
    private void DrawOurStuff()
    {
        if (_drawSiteToSiteLines)
            DrawSiteToSiteLines();
        
        DrawSiteEdgeLines();

        if (_showHelp)
            DrawHelpOverlay();

        if (_isMouseInsideWorld)
            DrawTooltip(GetHoveredSiteTooltipLines());
    }

    private void DrawSiteToSiteLines()
    {
        Dictionary<VoronoiSite, int> siteIndex = new Dictionary<VoronoiSite, int>(_plane.Sites.Count);
        for (int i = 0; i < _plane.Sites.Count; i++)
            siteIndex[_plane.Sites[i]] = i;

        for (int i = 0; i < _plane.Sites.Count; i++)
        {
            VoronoiSite site = _plane.Sites[i];
            if (site.SkippedAsDuplicate) continue;

            foreach (VoronoiSite neighbour in site.Neighbours)
            {
                if (!neighbour.Tesselated || neighbour.SkippedAsDuplicate) continue;

                // draw each pair once
                if (!siteIndex.TryGetValue(neighbour, out int j)) continue;
                if (j <= i) continue;

                ScreenCoord siteCoord = WorldToScreen(site.X, site.Y);
                ScreenCoord neighCoord = WorldToScreen(neighbour.X, neighbour.Y);

                double dx = neighCoord.X - siteCoord.X;
                double dy = neighCoord.Y - siteCoord.Y;
                double dist = Math.Sqrt(dx * dx + dy * dy);
                double rotation = Math.Atan2(dy, dx);

                _spriteBatch.Draw(
                    _pixelTexture,
                    new Vector2((float)siteCoord.X, (float)siteCoord.Y),
                    null,
                    _drawEdges ? _neighbourLinkColor : _neighbourLinkColorProminent,
                    (float)rotation,
                    Vector2.Zero,
                    new Vector2((float)dist, 1f),
                    SpriteEffects.None,
                    0.0f
                );
            }
        }
    }

    private void DrawSiteEdgeLines()
    {
        foreach (VoronoiEdge edge in _plane.Edges)
        {
            ScreenCoord p1 = WorldToScreen(edge.Start.X, edge.Start.Y);
            ScreenCoord p2 = WorldToScreen(edge.End.X, edge.End.Y);

            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            
            double dist = Math.Sqrt(dx * dx + dy * dy);
            double rotation = Math.Atan2(dy, dx);

            bool isHoveredEdge = _isMouseInsideWorld && _hoveredSite != null && (edge.Left == _hoveredSite || edge.Right == _hoveredSite);
            bool isSelectedEdge = _selectedSite != null && (edge.Left == _selectedSite || edge.Right == _selectedSite);
            bool isSelectionNeighbouringEdge = _selectedSite != null && (_selectedSite.Neighbours.Contains(edge.Left) || _selectedSite.Neighbours.Contains(edge.Right));

            if (!_drawEdges && !isHoveredEdge && !isSelectedEdge && !isSelectionNeighbouringEdge)
                continue; // skip drawing this edge if it's not important and edges are disabled
            
            Color lineColor = _edgeColor;
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
                new Vector2((float)p1.X, (float)p1.Y),
                null,
                lineColor,
                (float)rotation,
                Vector2.Zero,
                new Vector2((float)dist, lineThickness),
                SpriteEffects.None,
                0.0f
            );
        }
    }

    private List<string> GetHoveredSiteTooltipLines()
    {
        // Assign labels to points (A, B, C, ...)
        Dictionary<VoronoiPoint, char> pointLabels = _hoveredSite!.Points
            .Select((p, i) => new { Point = p, Label = (char)('A' + i) })
            .ToDictionary(x => x.Point, x => x.Label);

        int siteIndex = _plane.Sites.IndexOf(_hoveredSite);
        
        List<string> lines =
        [
            "Site #" + siteIndex + " " + _hoveredSite.ToString("F3"),
            "Points " + string.Join(", ", pointLabels.Select(kv => kv.Value + " " + kv.Key.ToString("F1"))),
            "Edges " + string.Join(", ", _hoveredSite.Edges.Select(e => pointLabels[e.Start] + "-" + pointLabels[e.End])),
            "Neighbours " + string.Join(", ", _hoveredSite.Neighbours.Select(n => n.ToString("F1")))
        ];

        return lines;
    }

    private void DrawTooltip(List<string> lines)
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

    private void DrawHelpOverlay()
    {
        float perSiteEdges = _plane.Sites.Count > 0 ? _plane.Sites.Sum(s => s.Edges.Count) / (float)_plane.Sites.Count : 0f;
        
        List<string> lines =
        [
            "Controls (~ to toggle):",
            "Mouse: left click select (right clear), wheel zoom, left drag pan",
            "Space: regenerate",
            "Tab: toggle uniform/gaussian (currently " + _pointGenerationMethod.ToString().ToLower() + ")",
            "R: toggle relax × 0/1/2 (currently " + _relaxIterations + ")",
            "1: toggle edges, 2: toggle site links",
            $"Currently: {_plane.Sites.Count} sites, {_plane.Edges.Count} edges ({perSiteEdges:F3} per site), {_plane.Points.Count} points"
        ];

        // Measure
        float width = 0f;
        float height = 0f;
        for (int i = 0; i < lines.Count; i++)
        {
            Vector2 size = _font.MeasureString(lines[i]);
            if (size.X > width) width = size.X;
            height += i == lines.Count - 1 ? size.Y : _font.LineHeight;
        }

        // Position in top-left within margin
        const int paddingHorizontal = 4;
        const int paddingVertical = 2;
        const float x = viewportMargin + 2;
        const float y = viewportMargin + 2;
        Rectangle rectangle = new Rectangle((int)x, (int)y, (int)(width + paddingHorizontal * 2), (int)(height + paddingVertical * 2));

        // Background box
        _spriteBatch.Draw(_pixelTexture, rectangle, _tooltipBackgroundColor);

        // Text
        Vector2 textPos = new Vector2(x + paddingHorizontal, y + paddingVertical);
        for (int i = 0; i < lines.Count; i++)
        {
            _spriteBatch.DrawString(_font, lines[i], textPos, _tooltipTextColor);
            textPos.Y += i == lines.Count - 1 ? _font.MeasureString(lines[i]).Y : _font.LineHeight;
        }
    }
    
    private void Generate()
    {
        // Set to current screen (minus visual margin)
        int width = GraphicsDevice.Viewport.Width - viewportMargin * 2;
        int height = GraphicsDevice.Viewport.Height - viewportMargin * 2;

        double minX;
        double minY;
        double maxX;
        double maxY;
        
        if (width <= 0 || height <= 0) // prevent exception
        {
            minX = 0;
            minY = 0;
            maxX = 0;
            maxY = 0;
        }
        else
        {
            minX = 0;
            minY = 0;
            maxX = width;
            maxY = height;
        }
        
        int numPoints = width * height / 400; // about 2000 points at 1280 x 720
        
        _plane = new VoronoiPlane(minX, minY, maxX, maxY);

        _plane.GenerateRandomSites(numPoints, _pointGenerationMethod);
        
        _plane.Tessellate();
        
        if (_relaxIterations > 0)
            _plane.Relax(_relaxIterations);

        // Dump stats
        Console.WriteLine($"Generated {_plane.Sites.Count} sites, {_plane.Edges.Count} edges, {_plane.Points.Count} points");
        
        float edgesPerSite = _plane.Sites.Count > 0 ? _plane.Sites.Sum(s => s.Edges.Count) / (float)_plane.Sites.Count : 0f;
        Console.WriteLine($"Edges per site: {edgesPerSite:F3}");
        int sitesWithMoreThan8Edges = _plane.Sites.Count(s => s.Edges.Count > 8);
        Console.WriteLine($"Sites with >8 edges: {sitesWithMoreThan8Edges}");
        
        float neighboursPerSite = _plane.Sites.Count > 0 ? _plane.Sites.Sum(s => s.Neighbours.Count) / (float)_plane.Sites.Count : 0f;
        Console.WriteLine($"Neighbours per site: {neighboursPerSite:F3}");
        int sitesWithMoreThan8Neighbours = _plane.Sites.Count(s => s.Neighbours.Count > 8);
        Console.WriteLine($"Sites with >8 neighbours: {sitesWithMoreThan8Neighbours}");
        
        float pointsPerSite = _plane.Sites.Count > 0 ? _plane.Sites.Sum(s => s.Points.Count) / (float)_plane.Sites.Count : 0f;
        Console.WriteLine($"Points per site: {pointsPerSite:F3}");
        int sitesWithMoreThan8Points = _plane.Sites.Count(s => s.Points.Count > 8);
        Console.WriteLine($"Sites with >8 points: {sitesWithMoreThan8Points}");
        
        float sitesPerPoint = _plane.Points.Count > 0 ? _plane.Sites.Sum(s => s.Points.Count) / (float)_plane.Points.Count : 0f;
        Console.WriteLine($"Sites per point: {sitesPerPoint:F3}");
        int pointsWithMoreThan3Sites = _plane.Points.Count(p => p.Sites.Count > 3);
        Console.WriteLine($"Points with >3 sites: {pointsWithMoreThan3Sites}");
        
        float edgesPerPoint = _plane.Points.Count > 0 ? _plane.Points.Sum(p => p.Edges.Count) / (float)_plane.Points.Count : 0f;
        Console.WriteLine($"Edges per point: {edgesPerPoint:F3}");
        int pointsWithMoreThan3Edges = _plane.Points.Count(p => p.Edges.Count > 3);
        Console.WriteLine($"Points with >3 edges: {pointsWithMoreThan3Edges}");
        
        // Reset camera after generating new content
        ResetCamera();
        
        // Clear any dangling interaction stuff
        _hoveredSite = null;
        _selectedSite = null;
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
        _cameraTransform.fitScale = (float)fit; // scale that makes entire world visible inside margins at zoom = 1
        _cameraTransform.scale = _cameraTransform.fitScale * (_cameraTransform.zoom == 0.0f ? 1.0f : _cameraTransform.zoom); // final pixels-per-world-unit used for rendering
        if (_cameraTransform.scale < 0.0001f) _cameraTransform.scale = 0.0001f; // numerical safety

        // The screen-space center of the drawable area (inside the margins)
        _cameraTransform.screenCenterX = viewportMargin + (float)(availableWidth * 0.5);
        _cameraTransform.screenCenterY = viewportMargin + (float)(availableHeight * 0.5);
    }

    /// <summary>
    /// Resets camera to show the whole world, centered.
    /// </summary>
    private void ResetCamera()
    {
        _cameraTransform.centerX = (_plane.MinX + _plane.MaxX) * 0.5;
        _cameraTransform.centerY = (_plane.MinY + _plane.MaxY) * 0.5;
        _cameraTransform.zoom = 1.0f;
        RecalculateTransform();
    }

    /// <summary>
    /// Converts screen coordinates to world coordinates using current camera transform.
    /// </summary>
    private Vector2 ScreenToWorld(int screenX, int screenY)
    {
        float safeScale = _cameraTransform.scale <= 0.0001f ? 0.0001f : _cameraTransform.scale;
        float worldX = (float)(_cameraTransform.centerX + (screenX - _cameraTransform.screenCenterX) / safeScale);
        float worldY = (float)(_cameraTransform.centerY + (screenY - _cameraTransform.screenCenterY) / safeScale);
        return new Vector2(worldX, worldY);
    }

    /// <summary>
    /// Converts world coordinates to screen coordinates using current camera transform.
    /// </summary>
    private ScreenCoord WorldToScreen(double worldX, double worldY)
    {
        double screenX = _cameraTransform.screenCenterX + (worldX - _cameraTransform.centerX) * _cameraTransform.scale;
        double screenY = _cameraTransform.screenCenterY + (worldY - _cameraTransform.centerY) * _cameraTransform.scale;
        return new ScreenCoord(screenX, screenY);
    }


    private struct CameraTransform
    {
        /// <summary> World-space X coordinate of the view center </summary>
        public double centerX;
        
        /// <summary> World-space Y coordinate of the view center </summary>
        public double centerY;
        
        /// <summary> User-controlled zoom factor applied on top of the fit-to-view scale </summary>
        public float zoom;
        
        /// <summary> Pixels-per-world-unit that would fit the entire world into the viewport margins </summary>
        public float fitScale;
        
        /// <summary> Final pixels-per-world-unit actually used for transforms this frame (fitScale × zoom) </summary>
        public float scale;
        
        /// <summary> Screen-space X of the drawable area's center (inside margins) </summary>
        public float screenCenterX;
        
        /// <summary> Screen-space Y of the drawable area's center (inside margins) </summary>
        public float screenCenterY;
    }

    private readonly struct ScreenCoord
    {
        public readonly double X;
        public readonly double Y;

        public ScreenCoord(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    
    private abstract record InteractionState;

    private sealed record IdleState : InteractionState;

    private sealed record PressedState(int StartX, int StartY) : InteractionState;

    private sealed record DraggingState(int LastX, int LastY) : InteractionState;
}
