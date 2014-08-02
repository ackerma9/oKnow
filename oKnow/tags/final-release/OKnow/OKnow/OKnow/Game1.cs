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
        private OptionsScreen optionsScreen;
        private GameBoard gameBoard;

        private IGameState gameState = new NoOpGameState();

        private Button powerUpButton;
        private Button endGameButton;

        private GameTime currentGameTime = new GameTime();

        /// <summary>
        /// The current screen that the game is on
        /// </summary>
        public Screen CurrentScreen
        {
            get { return currentScreen; }
            set { currentScreen = value; } 
        }

        /// <summary>
        /// Main constructor for the game loop
        /// </summary>
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = screenHeight;
            graphics.PreferredBackBufferWidth = screenWidth;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            singletonReference = this;

        }

        /// <summary>
        /// Singleton reference for the main game loop
        /// </summary>
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
            optionsScreen = new OptionsScreen();
            currentScreen = Screen.START;

            

        }

        protected void InitializeGameButtons(bool start)
        {
            if (start)
            {
                powerUpButton = new Button("Use PowerUp", new Vector2(AbstractTile.tileLength, graphics.PreferredBackBufferHeight - AbstractTile.tileLength), Game1.GameSingleton.UsePowerUp);
                endGameButton = new Button("End Game", new Vector2(graphics.PreferredBackBufferWidth - Button.Width - AbstractTile.tileLength, graphics.PreferredBackBufferHeight - AbstractTile.tileLength), Game1.GameSingleton.EndGame);
            }
            else
            {
                powerUpButton = null;
                endGameButton = null;
            }
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
            currentGameTime = gameTime;
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Escape))
                this.Exit();

            base.Update(gameTime);
            UI.IOSubject.Update(gameTime);

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
                case Screen.OPTIONS:
                    optionsScreen.Draw(spriteBatch);
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

        /// <summary>
        /// Getter for num players
        /// </summary>
        public int NumPlayers
        {
            get { return gameBoard.Players.Count; }
        }

        /// <summary>
        /// Starts the game with a set of given parameters
        /// </summary>
        /// <param name="numPlayers"> the number of players </param>
        /// <param name="c"> category </param>
        /// <param name="bs"> board size </param>
        /// <param name="bt"> board type </param>
        /// <param name="tileWeights"> set of tile weights </param>
        public void StartGame(int numPlayers, Category c, BoardSize bs, BoardType bt, int[] tileWeights)
        {
            currentScreen = Screen.BOARD;
            gameBoard = new GameBoard(20, 5, numPlayers, c, bs, bt, tileWeights);
            GameState = new PlayerMoveState();
            InitializeGameButtons(true);
        }

        /// <summary>
        /// Changes the screen to the options screen
        /// </summary>
        public void OptionsScreenGo()
        {
            currentScreen = Screen.OPTIONS;
            startScreen.RemoveObservers();
            optionsScreen.AddObservers();
        }

        /// <summary>
        /// Goes back from the options screen to the start screen
        /// </summary>
        public void OptionsScreenBack()
        {
            currentScreen = Screen.START;
            optionsScreen.RemoveObservers();
            startScreen.AddObservers();
        }

        /// <summary>
        /// Ends the game and goes to gameoever
        /// </summary>
        public void EndGame()
        {
            gameBoard.RemoveObservers();
            startScreen.AddObservers();
            startScreen.PlayTheme();
            currentScreen = Screen.GAMEOVER;
            InitializeGameButtons(false);
        }

        /// <summary>
        /// Checks to see if the current question is being displayed
        /// </summary>
        /// <param name="question"> current question </param>
        public Boolean IsCurrentQuestion(Question question)
        {
            return this.question == question && currentScreen == Screen.QUESTION;
        }

        /// <summary>
        /// Displays a given question for a given tile
        /// </summary>
        /// <param name="question"> given question </param>
        /// <param name="tile"> tile for the question </param>
        public void ShowQuestion(Question question, AbstractTile tile)
        {
            question.Reset(currentGameTime, tile);
            this.question = question;
            this.currentTile = tile;
            currentScreen = Screen.QUESTION;
        }

        /// <summary>
        /// Changes the game state once a question has been answered
        /// </summary>
        /// <param name="isCorrect"> whether the question was answered correctly or not </param>
        public void QuestionAnswered(Boolean isCorrect)
        {
            GameState.QuestionAnswered(isCorrect, question);
        }

        /// <summary>
        /// Getter for the current player
        /// </summary>
        public Player CurrentPlayer
        {
            get { return gameBoard.CurrentPlayer; }
        }

        /// <summary>
        /// Getter and setter for the game state
        /// </summary>
        public IGameState GameState
        {
            get { return gameState; }
            set
            {
                gameState = value;
                gameState.Activate();
            }
        }

        /// <summary>
        /// Displays the board on the screen
        /// </summary>
        public void ShowBoard()
        {
            currentScreen = Screen.BOARD;
            if (this.question != null)
            {
                this.question.RemoveObservers();
                this.question = null;
            }
        }

        /// <summary>
        /// Getter for the game board
        /// </summary>
        public GameBoard GameBoard
        {
            get { return gameBoard; }
        }

        /// <summary>
        /// Changes the game state when a powerup has been used
        /// </summary>
        public void UsePowerUp()
        {
            gameState.UsePowerUp();
        }

        /// <summary>
        /// Getter for the current question
        /// </summary>
        public Question CurrentQuestion
        {
            get { return question; }
        }
    }
}
