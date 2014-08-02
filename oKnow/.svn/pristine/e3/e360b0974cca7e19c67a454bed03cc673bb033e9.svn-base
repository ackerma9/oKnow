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
    public class GameBoard
    {
        public static int heightOffset = 3;
        public static int maxPlayers = 4;

        private AbstractTile[,] tileArray;
        private List<Player> players = new List<Player>();
        private int currentPlayerIndex = 0;

        private Category category;
        private int boardWidth;
        private int boardHeight;

        public GameBoard(int width, int height, int numPlayers, Category c, BoardSize bs, BoardType bt)
        {
            Player.Reset();

            tileArray = BoardGenerator.generateBoard(this, width, height, bs, bt);
            for (int i = 0; i < numPlayers; i++)
            {
                players.Add(new Player(BoardGenerator.StartTile));
            }

            this.category = c;
            boardWidth = width;
            boardHeight = height;
        }

        public Player CurrentPlayer
        {
            get { return players[currentPlayerIndex]; }
        }

        public void NextTurn()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
        }

        public List<Player> Players
        {
            get { return players; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Display oKnow. It's about brand gentlemen.
            String oKnowText = "oKnow";
            Vector2 oKnowTextSize = StaticFonts.PericlesFont50.MeasureString(oKnowText);
            int oKnowText_XLocation = (int)((Game1.screenWidth / 2) - (oKnowTextSize.X / 2));
            spriteBatch.DrawString(StaticFonts.PericlesFont50, oKnowText, new Vector2(oKnowText_XLocation , 5),
                Color.Orange, 0f, Vector2.Zero, 1, SpriteEffects.None, 0f);
            
            // displayer current player's stats
            players[this.currentPlayerIndex].drawStats(spriteBatch);

            // display scoreboard
            int xOffset = (int)(Game1.screenWidth * .8);

            for (int i = 0; i < players.Count(); i++)
            {
                Player current = players[i];
                current.drawScore(spriteBatch, i, xOffset);
            }

            for(int i = 0; i < boardWidth; i++)
            {
                for (int j = 0; j < boardHeight; j++)
                {
                    if (tileArray[i, j] != null)
                    {
                        tileArray[i, j].draw(spriteBatch);
                    }
                }
            }

            foreach (Player player in players)
            {
                player.draw(spriteBatch);
            }

        }

        public EndTile EndTile
        {
            get { return BoardGenerator.EndTile; }
        }

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

        public Player Winner
        {
            get
            {
                foreach (Player player in players)
                {
                    if (player.getTile() == BoardGenerator.EndTile)
                    {
                        return player;
                    }
                }
                return null;
            }
        }
    }
}
