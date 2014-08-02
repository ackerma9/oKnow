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
        public static readonly int screenWidth = 1280;
        public static readonly int screenHeight = 640;

        private Question question = null;
        public Question Question
        {
            get { return question; }
            set
            {
                if (question != null && value == null)
                {
                    this.gameBoard.NextTurn();
                }
                question = value; 
            } 
        }

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D pixel;
        private Screen currentScreen;

        Texture2D startImage;
        Texture2D startScreenButton;
        Texture2D numPlayerSelecter;
        public static Texture2D AnswerTile;
        public static Texture2D QuestionBox;
        public static Texture2D AnswerButton;
        StartScreen startScreen;
        int numPlayers;

        public static SpriteFont font;
        SpriteFont periclesFont;
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

            startScreen = new StartScreen(startImage, startScreenButton, numPlayerSelecter, periclesFont);
            currentScreen = Screen.START;
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

            TileTypeTextures.LoadContent(Content);

            AnswerButton = Content.Load<Texture2D>("Graphics/AnswerButton");
            QuestionBox = Content.Load<Texture2D>("Graphics/SampleQuestion");
            AnswerTile = Content.Load<Texture2D>("Graphics/StartScreenButton");
            startImage = Content.Load<Texture2D>("Graphics/StartImage");
            startScreenButton = Content.Load<Texture2D>("Graphics/StartScreenButton");
            numPlayerSelecter = Content.Load<Texture2D>("Graphics/NumPlayerSelecter");
            periclesFont = Content.Load<SpriteFont>("Pericles");
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

            switch (currentScreen)
            {
                case Screen.START:
                    break;
                case Screen.BOARD:
                    if (gameBoard == null)
                    {
                        gameBoard = new GameBoard(20, 5, numPlayers);
                    }
                    else
                    {
                        if (question != null)
                        {
                            currentScreen = Screen.QUESTION;
                        }
                    }
                    break;
                case Screen.QUESTION:
                    break;
                default:
                    break;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            if (gameBoard != null && gameBoard.Winner != null)
            {
                GraphicsDevice.Clear(gameBoard.Winner.Color);
            }
            else
            {
                GraphicsDevice.Clear(Color.White);
            }
            spriteBatch.Begin();

            switch (currentScreen)
            {
                case Screen.START:
                    startScreen.Draw(spriteBatch);
                    break;
                case Screen.BOARD:
                    gameBoard.Draw(spriteBatch);
                    break;
                case Screen.QUESTION:
                    if (question != null)
                    {
                        question.Draw(spriteBatch);
                    }
                    else
                    {
                        currentScreen = Screen.BOARD;
                    }
                    break;
                default:
                    startScreen.Draw(spriteBatch);
                    break;
            }

            spriteBatch.End();
            base.Draw(gameTime);

        }

        public Texture2D getPixel()
        {
            return pixel;
        }

        public int NumPlayers
        {
            get { return numPlayers; }
        }

        public void StartGame(int numPlayers)
        {
            currentScreen = Screen.BOARD;
            this.numPlayers = numPlayers;
        }
    }
}
