using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace OKnow
{
    public class GameBoard
    {
        public static int heightOffset = 2;
        public static int maxPlayers = 4;

        private Tile[,] tileArray;
        private List<Player> players = new List<Player>();
        private int currentPlayerIndex = 0;


        private int boardWidth;
        private int boardHeight;

        public GameBoard(int width, int height, int numPlayers)
        {
            Player.Reset();
            tileArray = BoardGenerator.generateBoard(this, width, height);
            for (int i = 0; i < numPlayers; i++)
            {
                players.Add(new Player(BoardGenerator.StartTile));
            }

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

        public void Draw(SpriteBatch spriteBatch)
        {
            String text = "Current Player";
            Vector2 textSize = Game1.font.MeasureString(text);
            spriteBatch.Draw(Game1.getSingleton().getPixel(), new Rectangle(0, 0, (int)(textSize.X), (int)(textSize.Y)), CurrentPlayer.Color);
            spriteBatch.DrawString(Game1.font, text, new Vector2(0), Color.Black);

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

        public Tile EndTile
        {
            get { return BoardGenerator.EndTile; }
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
