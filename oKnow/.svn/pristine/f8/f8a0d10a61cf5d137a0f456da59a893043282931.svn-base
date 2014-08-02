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
    /// <summary>
    /// Describes an abstract board tile
    /// </summary>
    public abstract class AbstractTile : IOObserver
    {
        private RectangleLeftClick recLeftClick;

        public static readonly int tileLength = 64;
        private int boardX;
        private int boardY;
        private GameBoard board;

        /// <summary>
        /// Constructs an abstract board tile
        /// </summary>
        /// <param name="board">Board the tile is a member of</param>
        /// <param name="boardX">x position</param>
        /// <param name="boardY">y position</param>
        public AbstractTile(GameBoard board, int boardX, int boardY)
        {
            this.board = board;
            this.boardX = boardX;
            this.boardY = boardY;
            recLeftClick = new RectangleLeftClick(this.Outline);
            IOSubject.AddObserver(recLeftClick, this);
        }

        /// <summary>
        /// Returns a rectangle which outlines the boundry of the tile
        /// </summary>
        public Rectangle Outline
        {
            get { return new Rectangle(tileLength * boardX, tileLength * (boardY + GameBoard.heightOffset), AbstractTile.tileLength, AbstractTile.tileLength); }
        }

        /// <summary>
        /// Returns the X position of the tile
        /// </summary>
        public int BoardX
        {
            get { return boardX; }
            set { boardX = value; }
        }

        /// <summary>
        /// Returns the Y position of the tile
        /// </summary>
        public int BoardY
        {
            get { return boardY; }
            set { boardY = value; }
        }

        /// <summary>
        /// The board that this tile is a part of
        /// </summary>
        public GameBoard Board
        {
            get { return board; }
            set { board = value; }
        }

        /// <summary>
        /// Returns true if the other tile is adjacent to this
        /// </summary>
        /// <param name="other">Other tile</param>
        /// <returns>true if the other tile is adjacent to this</returns>
        public Boolean IsAdjacent(AbstractTile other)
        {
            return Math.Abs(this.boardX - other.boardX) + Math.Abs(this.boardY - other.boardY) == 1;
        }

        /// <summary>
        /// Draws the tile on the screen
        /// </summary>
        /// <param name="spriteBatch"></param>
        public abstract void Draw(SpriteBatch spriteBatch);

        /// <summary>
        /// The tile's notify method for IO events
        /// </summary>
        /// <param name="e">IO event</param>
        public void Notify(IOEvent e)
        {
            if (e == recLeftClick)
            {
                this.LeftClick();
            }
        }

        /// <summary>
        /// This method executes the effects of left clicking a tile
        /// </summary>
        protected void LeftClick()
        {
            Game1.GameSingleton.GameState.TileClick(this);
        }

        /// <summary>
        /// Returns the powerup for this tiles
        /// </summary>
        /// <returns></returns>
        public virtual IGameState GetPowerUp()
        {
            return null;
        }
    }
}
