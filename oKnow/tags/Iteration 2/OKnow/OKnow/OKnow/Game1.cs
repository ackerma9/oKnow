using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using OKnow.UI;
using OKnow.Questions;

namespace OKnow
{
    // Sample Comment - Karan Batra
    // Sample Comment - Ben Alexander
    // Sample Comment - Vikram Jayashankar
    // Sample Comment - Danny Briggs
    // Bryan 1 was here. In your face, Bryan 2 (maybe Brian 2?)
    // The last horse makes it to gate (Brian2)

    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private static Game1 game1;

        public static bool DisplayQ = false;
        public static Question q1 = new Question(Category.NONE, "What Color is the sky?", new string[] { "Green", "Red", "Blue", "Yellow" }, Answer.THREE);
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D pixel;

        Texture2D banjoKazooieTile;
        Texture2D deathTile;
        Texture2D endTile;
        Texture2D eyeTile;
        Texture2D jokerTile;
        Texture2D musicTile;
        Texture2D startTile;
        Texture2D timedTile;

        public static SpriteFont font;
        GameBoard gameBoard;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 640;
            graphics.PreferredBackBufferWidth = 1280;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            game1 = this;
        }

        public static Game1 getSingleton()
        {
            return game1;
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

            base.Initialize();
            
            TileTypeTextures.setBanjoKazooieTile(banjoKazooieTile);
            TileTypeTextures.setDeathTile(deathTile);
            TileTypeTextures.setEndTile(endTile);
            TileTypeTextures.setEyeTile(eyeTile);
            TileTypeTextures.setJokerTile(jokerTile);
            TileTypeTextures.setMusicTile(musicTile);
            TileTypeTextures.setStartTile(startTile);
            TileTypeTextures.setTimedTile(timedTile);

            gameBoard = new GameBoard(20, 5);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            pixel = new Texture2D(GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            pixel.SetData(new[] { Color.White }); // so that we can draw whatever color we want on top of it

            banjoKazooieTile = Content.Load<Texture2D>("Graphics/BanjoKazooieTile");
            deathTile = Content.Load<Texture2D>("Graphics/DeathTile");
            endTile = Content.Load<Texture2D>("Graphics/EndTile");
            eyeTile = Content.Load<Texture2D>("Graphics/eyeTile");
            jokerTile = Content.Load<Texture2D>("Graphics/jokerTile");
            musicTile = Content.Load<Texture2D>("Graphics/MusicTile");
            startTile = Content.Load<Texture2D>("Graphics/StartTile");
            timedTile = Content.Load<Texture2D>("Graphics/TimedTile");
            font = Content.Load<SpriteFont>("SpriteFont1");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            UI.IOSubject.Update();
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            gameBoard.draw(spriteBatch);

            if(DisplayQ)
                q1.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);

        }

        public Texture2D getPixel()
        {
            return pixel;
        }
    }
}
