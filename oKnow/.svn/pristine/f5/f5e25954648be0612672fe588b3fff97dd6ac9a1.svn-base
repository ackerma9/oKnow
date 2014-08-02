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
using OKnow.StaticContent;
using OKnow.Pieces;

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
        private static Game1 singletonReference;
        public static readonly int screenWidth = 1280;
        public static readonly int screenHeight = 640;
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;

        private Question question = null;
        private AbstractTile currentTile = null;

        private Screen currentScreen;
        private StartScreen startScreen;
        private GameBoard gameBoard;

        private IGameState gameState = new NoOpGameState();

        private Button powerUpButton;
        private Button endGameButton;

        public Screen CurrentScreen
        {
            get { return currentScreen; }
            set { currentScreen = value; } 
        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = screenHeight;
            graphics.PreferredBackBufferWidth = screenWidth;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            singletonReference = this;

        }

        public static Game1 GameSingleton
        {
            get { return singletonReference; }
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

            startScreen = new StartScreen();
            currentScreen = Screen.START;

            int endGameButtonWidth = (int)StaticTextures.EndGameButton.Width / 2;

            powerUpButton = new Button("Use PowerUp", new Vector2(AbstractTile.tileLength, graphics.PreferredBackBufferHeight - AbstractTile.tileLength), Game1.GameSingleton.UsePowerUp);
            endGameButton = new Button("End Game", new Vector2(graphics.PreferredBackBufferWidth - Button.Width - AbstractTile.tileLength, graphics.PreferredBackBufferHeight - AbstractTile.tileLength), Game1.GameSingleton.EndGame);

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            SingletonContentManager.Initialize(Content);

            StaticSounds.LoadContent(Content);
            StaticTextures.LoadContent(Content, GraphicsDevice);
            StaticFonts.LoadContent(Content);

            
            VideoGameQuestions.LoadContent(Content);
            MovieQuestions.LoadContent(Content);
            MusicQuestions.LoadContent(Content);
            TVShowQuestions.LoadContent(Content);

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
            base.Update(gameTime);
            UI.IOSubject.Update();

            if (question != null && currentScreen == Screen.QUESTION)
            {
                question.Update(gameTime, currentTile);
            }
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
                    endGameButton.Draw(spriteBatch);
                    powerUpButton.Draw(spriteBatch);
                    break;
                case Screen.QUESTION:
                    question.Draw(spriteBatch, gameTime, currentTile);
                    break;
                default:
                    startScreen.Draw(spriteBatch);
                    break;
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public int NumPlayers
        {
            get { return gameBoard.Players.Count; }
        }

        public void StartGame(int numPlayers, Category c)
        {
            currentScreen = Screen.BOARD;
            gameBoard = new GameBoard(20, 5, numPlayers, c);
            GameState = new PlayerMoveState();

        }
        public void EndGame()
        {
            currentScreen = Screen.GAMEOVER;
        }

        public Boolean IsCurrentQuestion(Question question)
        {
            return this.question == question && currentScreen == Screen.QUESTION;
        }

        public void ShowQuestion(Question question, AbstractTile tile)
        {
            question.Reset();
            this.question = question;
            this.currentTile = tile;
            currentScreen = Screen.QUESTION;
        }

        public void QuestionAnswered(Boolean isCorrect)
        {
            if (isCorrect)
            {
                StaticSounds.CorrectAnswer.Play();
            }
            else
            {
                StaticSounds.IncorrectAnswer.Play();
            }
            GameState.QuestionAnswered(isCorrect, question);
        }

        public Player CurrentPlayer
        {
            get { return gameBoard.CurrentPlayer; }
        }

        public IGameState GameState
        {
            get { return gameState; }
            set
            {
                gameState = value;
                gameState.Activate();
            }
        }

        public void ShowBoard()
        {
            currentScreen = Screen.BOARD;
            if (this.question != null)
            {
                this.question.RemoveObservers();
                this.question = null;
            }
        }

        public GameBoard GameBoard
        {
            get { return gameBoard; }
        }

        public void UsePowerUp()
        {
            gameState.UsePowerUp();
        }
    }
}
