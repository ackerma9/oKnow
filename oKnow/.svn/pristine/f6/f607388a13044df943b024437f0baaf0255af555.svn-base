using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.UI;
using OKnow.Questions;

namespace OKnow.Pieces
{
    public abstract class AbstractTile : IOObserver
    {
        private RectangleLeftClick recLeftClick;

        public static readonly int tileLength = 64;
        private int boardX;
        private int boardY;
        private GameBoard board;

        public AbstractTile(GameBoard board, int boardX, int boardY)
        {
            this.board = board;
            this.boardX = boardX;
            this.boardY = boardY;
            recLeftClick = new RectangleLeftClick(this.Outline);
            IOSubject.AddObserver(recLeftClick, this);
        }

        public Rectangle Outline
        {
            get { return new Rectangle(tileLength * boardX, tileLength * (boardY + GameBoard.heightOffset), AbstractTile.tileLength, AbstractTile.tileLength); }
        }

        public int BoardX
        {
            get { return boardX; }
            set { boardX = value; }
        }

        public int BoardY
        {
            get { return boardY; }
            set { boardY = value; }
        }

        public GameBoard Board
        {
            get { return board; }
            set { board = value; }
        }

        public Boolean IsAdjacent(AbstractTile other)
        {
            return Math.Abs(this.boardX - other.boardX) + Math.Abs(this.boardY - other.boardY) == 1;
        }

        public abstract void draw(SpriteBatch spriteBatch);

        public void Notify(IOEvent e)
        {
            if (e == recLeftClick)
            {
                this.LeftClick();
            }
        }

        protected void LeftClick()
        {
            Game1.GameSingleton.GameState.TileClick(this);
        }

        public virtual IGameState GetPowerUp()
        {
            return null;
        }
    }
}
