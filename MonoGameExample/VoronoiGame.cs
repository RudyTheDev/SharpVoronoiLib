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
    private readonly GraphicsDeviceManager _graphics;

    private SpriteBatch _spriteBatch;
    
    private Texture2D _pixelTexture;

    private KeyboardState _lastKeyboardState;

    private List<VoronoiEdge> _edges;


    public VoronoiGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        _graphics.PreferredBackBufferWidth = 1280;
        _graphics.PreferredBackBufferHeight = 720;
    }

    
    protected override void Initialize()
    {
        base.Initialize();
        
        _pixelTexture = new Texture2D(GraphicsDevice, 1, 1);
        _pixelTexture.SetData(new[] { Color.White });
        
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

        Generate();
        
        if (keyboardState.IsKeyDown(Keys.Space) && _lastKeyboardState.IsKeyUp(Keys.Space))
            Generate();

        _lastKeyboardState = keyboardState;

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        foreach (VoronoiEdge edge in _edges)
        {
            Vector2 start = new Vector2((float)edge.Start.X, (float)edge.Start.Y);
            Vector2 end = new Vector2((float)edge.End.X, (float)edge.End.Y);
            
            float dist = Vector2.Distance(start, end);
            float rotation = (float)Math.Atan2(end.Y - start.Y, end.X - start.X);
            
            _spriteBatch.Draw(
                _pixelTexture,
                start,
                null,
                Color.White,
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
        int width = _graphics.PreferredBackBufferWidth;
        int height = _graphics.PreferredBackBufferHeight;
        int numPoints = width * height / 400; // about 2000 points at 1280 x 720
        
        List<VoronoiSite> sites = new List<VoronoiSite>(numPoints);

        Random rand = new Random();
        for (int i = 0; i < numPoints; i++)
        {
            sites.Add(
                new VoronoiSite(
                    rand.Next(width), 
                    rand.Next(height)
                )
            );
        }

        VoronoiPlane plane = new VoronoiPlane(0, 0, width, height);
        
        plane.SetSites(sites);
        
        plane.Tessellate();
        
        _edges = plane.Relax();
    }
}