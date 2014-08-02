using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace OKnow
{
    public class Player
    {
        private Tile currentTile;

        public Player(Tile tile)
        {
            currentTile = tile;
        }

        public void setTile(Tile tile)
        {
            currentTile = tile;
        }

        public Tile getTile()
        {
            return currentTile;
        }

        public void draw(SpriteBatch spriteBatch)
        {
            Texture2D pixel = Game1.getSingleton().getPixel();
            Rectangle outline = new Rectangle(Tile.tileLength * currentTile.BoardX, Tile.tileLength * (currentTile.BoardY + GameBoard.heightOffset), Tile.tileLength, Tile.tileLength);
            // Draw top line
            spriteBatch.Draw(pixel, new Rectangle(outline.X, outline.Y, outline.Width, 5), Color.Red);

            // Draw left line
            spriteBatch.Draw(pixel, new Rectangle(outline.X, outline.Y, 5, outline.Height), Color.Red);

            // Draw right line
            spriteBatch.Draw(pixel, new Rectangle((outline.X + outline.Width - 5), outline.Y, 5, outline.Height), Color.Red);

            // Draw bottom line
            spriteBatch.Draw(pixel, new Rectangle(outline.X, outline.Y + outline.Height - 5, outline.Width, 5), Color.Red);

        }
    }
}
