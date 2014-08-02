using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.StaticContent;
using OKnow.Questions;
using OKnow.Pieces;
using OKnow.UI;

namespace OKnow
{
    /// <summary>
    /// Represents the board, contains all the tiles, players, and other game information
    /// </summary>
    public class GameBoard
    {
        public static int heightOffset = 3;
        public static int maxPlayers = 4;

        private AbstractTile[,] tileArray;
        private List<Player> players = new List<Player>();
        private int currentPlayerIndex = 0;
        private List<Player> leaderBoard = new List<Player>();

        private Category category;
        private int boardWidth;
        private int boardHeight;

        /// <summary>
        /// Main constructor for the gameboard
        /// </summary>
        /// <param name="width"> width of the board </param>
        /// <param name="height"> height of the board </param>
        /// <param name="numPlayers"> number of players </param>
        /// <param name="c"> category </param>
        /// <param name="bs"> board size </param>
        /// <param name="bt"> board type </param>
        /// <param name="tileWeights"> set of tile weights </param>
        public GameBoard(int width, int height, int numPlayers, Category c, BoardSize bs, BoardType bt, int[] tileWeights)
        {
            Player.Reset();

            tileArray = BoardGenerator.GenerateBoard(this, width, height, bs, bt, tileWeights);
            for (int i = 0; i < numPlayers; i++)
            {
                players.Add(new Player(BoardGenerator.StartTile));
            }

            this.category = c;
            boardWidth = width;
            boardHeight = height;

            for (int i = 0; i < numPlayers; i++)
            {
                leaderBoard.Add(players[i]);
            }
        }

        /// <summary>
        /// Returns the Current Player
        /// </summary>
        public Player CurrentPlayer
        {
            get { return players[currentPlayerIndex]; }
        }
        
        /// <summary>
        /// Advances the current player
        /// </summary>
        public void NextTurn()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;

            if (currentPlayerIndex == 0)
            {
                this.Sort();
            }
        }

        /// <summary>
        /// Returns the list of players
        /// </summary>
        public List<Player> Players
        {
            get { return players; }
        }

        /// <summary>
        /// getter for the leaderboard
        /// </summary>
        public List<Player> Leaderboard
        {
            get { return leaderBoard; }
        }

        /// <summary>
        /// Getter and setter for the Category
        /// </summary>
        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// sorts the leaderboard in descending order based on player scores
        /// </summary>
        public void Sort()
        {
            leaderBoard = leaderBoard.OrderByDescending(p => p.totalScore).ToList();
        }

        /// <summary>
        /// Draws the GameBoard and all its components
        /// </summary>
        /// <param name="spriteBatch"> where to draw </param>
        public void Draw(SpriteBatch spriteBatch)
        {
            //Display oKnow. It's about brand gentlemen.
            String oKnowText = "oKnow";
            Vector2 oKnowTextSize = StaticFonts.PericlesFont50.MeasureString(oKnowText);
            int oKnowText_XLocation = (int)((Game1.screenWidth / 2) - (oKnowTextSize.X / 2));
            spriteBatch.DrawString(StaticFonts.PericlesFont50, oKnowText, new Vector2(oKnowText_XLocation , 5),
                Color.Orange, 0f, Vector2.Zero, 1, SpriteEffects.None, 0f);
            
            // displayer current player's stats
            players[this.currentPlayerIndex].DrawStats(spriteBatch);

            // display scoreboard
            int xOffset = (int)(Game1.screenWidth * .8);

            for (int i = 0; i < players.Count(); i++)
            {
                Player current = leaderBoard[i];
                current.DrawScore(spriteBatch, i, xOffset);
            }

            // draw tiles for board
            for(int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeight; j++)
                {
                    if (tileArray[i, j] != null)
                    {
                        tileArray[i, j].Draw(spriteBatch);
                    }
                }
            }

            foreach (Player player in players)
            {
                player.Draw(spriteBatch);
            }

        }


        /// <summary>
        /// Returns the end tile of the board
        /// </summary>
        public EndTile EndTile
        {
            get { return BoardGenerator.EndTile; }
        }

        /// <summary>
        /// Removes this observer from the IO subject
        /// </summary>
        public void RemoveObservers()
        {
            for (int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeight; j++)
                {
                    if (tileArray[i, j] != null)
                    {
                        IOSubject.RemoveObserver(tileArray[i, j]);
                    }
                }
            }
        }

        /// <summary>
        /// Returns the winner.  If there is no winner, null is returned.
        /// </summary>
        public Player Winner
        {
            get
            {
                foreach (Player player in players)
                {
                    if (player.GetTile() == BoardGenerator.EndTile)
                    {
                        return player;
                    }
                }
                return null;
            }
        }
    }
}
