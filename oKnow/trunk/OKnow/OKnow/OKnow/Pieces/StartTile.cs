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
    /// Describes a start tile
    /// </summary>
    public class StartTile : AbstractTile
    {
        /// <summary>
        /// Constructs the start tile by using the parent constructor
        /// </summary>
        /// <param name="board">The Game board the tile is a member of</param>
        /// <param name="boardX">x position</param>
        /// <param name="boardY">y position</param>
        public StartTile(GameBoard board, int boardX, int boardY)
            : base(board, boardX, boardY)
        {
        }

        /// <summary>
        /// Draws the start tile using the start tile sprite
        /// </summary>
        /// <param name="spriteBatch">The spritebatch object used to draw the sprite</param>
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(StaticTextures.StartTile, new Vector2(tileLength * BoardX, tileLength * (BoardY + GameBoard.heightOffset)), Color.White);
        }
    }
}