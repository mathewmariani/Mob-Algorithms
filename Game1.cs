using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MOBAlgorithms.Desktop
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        Texture2D slimeTexture;
        Vector2 slimePosition;
        float slimeSpeed;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            slimePosition = new Vector2(graphics.PreferredBackBufferWidth / 2,
                graphics.PreferredBackBufferHeight / 2 + graphics.PreferredBackBufferHeight / 4);
            slimeSpeed = 100f;

            Console.WriteLine(graphics.PreferredBackBufferWidth);
            Console.WriteLine(graphics.PreferredBackBufferHeight);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            slimeTexture = Content.Load<Texture2D>("mobs/slime1-3x");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            var kstate = Keyboard.GetState();

            if (kstate.IsKeyDown(Keys.Left))
                slimePosition.X -= slimeSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.Right))
                slimePosition.X += slimeSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            slimePosition.X = Math.Min(Math.Max(slimeTexture.Width / 2, slimePosition.X), graphics.PreferredBackBufferWidth - slimeTexture.Width / 2);
            slimePosition.Y = Math.Min(Math.Max(slimeTexture.Height / 2, slimePosition.Y), graphics.PreferredBackBufferHeight - slimeTexture.Height / 2);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(slimeTexture, slimePosition, null, Color.White, 0f,
                new Vector2(slimeTexture.Width / 2, slimeTexture.Height / 2),
                Vector2.One, SpriteEffects.None, 0f);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
