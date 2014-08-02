using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace OKnow
{
    public class GameBoard
    {
        public static int heightOffset = 2;
        private Tile[,] tileArray;
        private Player player;
        private int boardWidth;
        private int boardHeight;

        public GameBoard(int width, int height)
        {
            tileArray = BoardGenerator.generateBoard(this, width, height);
            player = new Player(BoardGenerator.getStartTile());

            boardWidth = width;
            boardHeight = height;
        }

        public Player Player
        {
            get { return player; }
        }

        public void draw(SpriteBatch spriteBatch)
        {
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
            player.draw(spriteBatch);
        }
    }
}
