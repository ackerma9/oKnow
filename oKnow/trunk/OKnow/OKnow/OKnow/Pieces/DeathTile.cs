using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.UI;
using OKnow.Questions;
using OKnow.StaticContent;

namespace OKnow.Pieces
{
    /// <summary>
    /// Describes a Death Tile
    /// </summary>
    public class DeathTile : AbstractTile
    {
        /// <summary>
        /// Constructs the death tile by using the parent constructor
        /// </summary>
        /// <param name="board">The Game board the tile is a member of</param>
        /// <param name="boardX">x position</param>
        /// <param name="boardY">y position</param>
        public DeathTile(GameBoard board, int boardX, int boardY)
            : base(board, boardX, boardY)
        {
        }

        /// <summary>
        /// Draws the death tile using the death tile sprite
        /// </summary>
        /// <param name="spriteBatch">The spritebatch object used to draw the sprite</param>
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(StaticTextures.DeathTile, new Vector2(tileLength * BoardX, tileLength * (BoardY + GameBoard.heightOffset)), Color.White);
        }
    }
}