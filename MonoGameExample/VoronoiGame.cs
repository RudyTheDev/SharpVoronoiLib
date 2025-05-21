using System;
using System.Collections.Generic;
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

    
    private readonly GraphicsDeviceManager _graphics;

    private SpriteBatch _spriteBatch;
    
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
    }

    protected override void Update(GameTime gameTime)
    {
        KeyboardState keyboardState = Keyboard.GetState();
        
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || keyboardState.IsKeyDown(Keys.Escape))
            Exit();

        //Generate();
        
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

        _spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Opaque, SamplerState.PointWrap);

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
        
        _spriteBatch.End();

        base.Draw(gameTime);
    }

    
    private void Generate()
    {
        // Set to current screen
        int width = GraphicsDevice.Viewport.Width - (edgeDistance * 2);
        int height = GraphicsDevice.Viewport.Height - (edgeDistance * 2);
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

        _plane = new VoronoiPlane(0, 0, width, height);
        
        _plane.SetSites(sites);
        
        _plane.Tessellate();
        
        _plane.Relax();
    }
}