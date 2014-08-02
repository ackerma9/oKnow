using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.UI;
using OKnow.Questions;

namespace OKnow
{
    public class Tile : IOObserver
    {
        private RectangleLeftClick recLeftClick;

        public static readonly int tileLength = 64;
        private int boardX;
        private int boardY;
        private TileType tileType;
        private GameBoard board;
        private Question question;

        public Tile(GameBoard board, TileType tileType, int boardX, int boardY)
        {
            this.board = board;
            this.tileType = tileType;
            this.boardX = boardX;
            this.boardY = boardY;
            recLeftClick = new RectangleLeftClick(this.Outline);
            IOSubject.AddObserver(recLeftClick, this);
        }

        public Rectangle Outline
        {
            get { return new Rectangle(tileLength * boardX, tileLength * (boardY + GameBoard.heightOffset), Tile.tileLength, Tile.tileLength); }
        }

        public void setQuestion(Question quest){
            question = quest;
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

        public TileType TileType
        {
            get { return tileType; }
            set { tileType = value; }
        }

        public Question Question
        {
            get { return question; }
        }

        public Boolean IsAdjacent(Tile other)
        {
            return Math.Abs(this.boardX - other.boardX) + Math.Abs(this.boardY - other.boardY) == 1;
        }

        public void draw(SpriteBatch spriteBatch)
        {
            if (tileType != TileType.NONE)
            {
                spriteBatch.Draw(TileTypeTextures.getTileGraphic(tileType), new Vector2(tileLength * boardX, tileLength * (boardY + GameBoard.heightOffset)), Color.White);
            }
        }

        public void Notify(IOEvent e)
        {
            if (e == recLeftClick)
            {
                if (board.CurrentPlayer.getTile().IsAdjacent(this) && Game1.getSingleton().Question == null)
                {
                    board.CurrentPlayer.setTile(this);
                    Game1.getSingleton().Question = board.CurrentPlayer.getTile().question;
                }
            }
        }
    }
}
