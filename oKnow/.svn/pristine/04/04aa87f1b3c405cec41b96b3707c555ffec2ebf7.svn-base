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
    public class MusicTile : AbstractTile
    {
        public MusicTile(GameBoard board, int boardX, int boardY)
            : base(board, boardX, boardY)
        {
        }

        public override void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(StaticTextures.MusicTile, new Vector2(tileLength * BoardX, tileLength * (BoardY + GameBoard.heightOffset)), Color.White);
        }

        protected override void LeftClick()
        {
            Game1.GameSingleton.GameState.TileClick(this);
        }
    }
}