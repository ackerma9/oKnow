using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using OKnow.UI;
using OKnow.Questions;
using Microsoft.Xna.Framework;
using OKnow.StaticContent;
namespace OKnow
{
    public class StartScreen : IOObserver
    {
        private Rectangle startImageRec;
        private Rectangle startScreenButtonRec;
        private Rectangle numPlayerSelecterRec;
        private Rectangle categoryButtonRec;
        private Rectangle boardSizeButtonRec;
        private Rectangle boardTypeButtonRec;

        private int numPlayers;
        private int currentCategoryIndex;
        private int currentBoardSizeSelectorIndex;
        private int currentBoardTypeIndex;

        private RectangleLeftClick startButtonClick;
        private RectangleLeftClick playerLeftArrowClick;
        private RectangleLeftClick playerRightArrowClick;
        private RectangleLeftClick categoryLeftArrowClick;
        private RectangleLeftClick categoryRightArrowClick;
        private RectangleLeftClick boardSizeLeftArrowClick;
        private RectangleLeftClick boardSizeRightArrowClick;
        private RectangleLeftClick boardTypeLeftArrowClick;
        private RectangleLeftClick boardTypeRightArrowClick;

        public StartScreen()
        {
            numPlayers = 1;
            currentCategoryIndex = 0;
            currentBoardSizeSelectorIndex = 0;
            currentBoardTypeIndex = 0;
            RectangleHelper();
            AddObservers();
        }

        public void AddObservers()
        {
            IOSubject.AddObserver(startButtonClick, this);
            IOSubject.AddObserver(playerLeftArrowClick, this);
            IOSubject.AddObserver(playerRightArrowClick, this);
            IOSubject.AddObserver(categoryLeftArrowClick, this);
            IOSubject.AddObserver(categoryRightArrowClick, this);
            IOSubject.AddObserver(boardSizeLeftArrowClick, this);
            IOSubject.AddObserver(boardSizeRightArrowClick, this);
            IOSubject.AddObserver(boardTypeLeftArrowClick, this);
            IOSubject.AddObserver(boardTypeRightArrowClick, this);
        }

        public void RemoveObservers()
        {
            IOSubject.RemoveObserver(this);
        }

        private void RectangleHelper()
        {
            startImageRec = new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight);
            startScreenButtonRec = new Rectangle(1020, 50, 200, 70);
            numPlayerSelecterRec = new Rectangle(1020, 160, 200, 70);
            categoryButtonRec = new Rectangle(1020, 270, 200, 70);
            boardSizeButtonRec = new Rectangle(1020, 380, 200, 70);
            boardTypeButtonRec = new Rectangle(1020, 490, 200, 70);

            startButtonClick = new RectangleLeftClick(startScreenButtonRec);
            playerLeftArrowClick = new RectangleLeftClick(GetLeftArrow(numPlayerSelecterRec));
            playerRightArrowClick = new RectangleLeftClick(GetRightArrow(numPlayerSelecterRec));
            categoryLeftArrowClick = new RectangleLeftClick(GetLeftArrow(categoryButtonRec));
            categoryRightArrowClick = new RectangleLeftClick(GetRightArrow(categoryButtonRec));
            boardSizeLeftArrowClick = new RectangleLeftClick(GetLeftArrow(boardSizeButtonRec));
            boardSizeRightArrowClick = new RectangleLeftClick(GetRightArrow(boardSizeButtonRec));
            boardTypeLeftArrowClick = new RectangleLeftClick(GetLeftArrow(boardTypeButtonRec));
            boardTypeRightArrowClick = new RectangleLeftClick(GetRightArrow(boardTypeButtonRec));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(StaticTextures.StartImage, startImageRec, Color.White);

            String text = "oKnow";
            spriteBatch.DrawString(StaticFonts.PericlesFont70, text, new Vector2(20, 100), Color.Orange, 0f,
                Vector2.Zero, 1, SpriteEffects.None, 0f);

            String playerText = "Number of Players";
            Vector2 playerTextSize = StaticFonts.PericlesFont18.MeasureString(playerText);
            int playerX = (int)(numPlayerSelecterRec.X + (numPlayerSelecterRec.Width / 2) - (playerTextSize.X / 2));
            int playerY = (int)(numPlayerSelecterRec.Y - playerTextSize.Y);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, playerText,
                new Vector2(playerX, playerY), Color.Orange);

            String categoryText = "Category";
            Vector2 categoryTextSize = StaticFonts.PericlesFont18.MeasureString(categoryText);
            int categoryX = (int)(categoryButtonRec.X + (categoryButtonRec.Width / 2) - (categoryTextSize.X / 2));
            int categoryY = (int)(categoryButtonRec.Y - categoryTextSize.Y);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, categoryText, 
                new Vector2(categoryX, categoryY), Color.Orange);

            String boardSizeText = "Board Size";
            Vector2 boardTextSize = StaticFonts.PericlesFont18.MeasureString(boardSizeText);
            int boardtextX = (int)(boardSizeButtonRec.X + (boardSizeButtonRec.Width / 2) - (boardTextSize.X / 2));
            int boardtextY = (int)(boardSizeButtonRec.Y - boardTextSize.Y);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, boardSizeText,
                new Vector2(boardtextX, boardtextY), Color.Orange);

            String boardStyleText = "Board Style";
            Vector2 boardStyleSize = StaticFonts.PericlesFont18.MeasureString(boardStyleText);
            int boardstyleX = (int)(boardTypeButtonRec.X + (boardTypeButtonRec.Width / 2) - (boardStyleSize.X / 2));
            int boardstyleY = (int)(boardTypeButtonRec.Y - boardStyleSize.Y);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, boardStyleText,
                new Vector2(boardstyleX, boardstyleY), Color.Orange);

            spriteBatch.Draw(StaticTextures.StartScreenButton, startScreenButtonRec, Color.White);
            spriteBatch.Draw(StaticTextures.NumPlayerSelecter, numPlayerSelecterRec, Color.White);
            spriteBatch.Draw(StaticTextures.categoryButtons[currentCategoryIndex], categoryButtonRec, Color.White);
            spriteBatch.Draw(StaticTextures.boardSizeSelector[currentBoardSizeSelectorIndex], boardSizeButtonRec, Color.White);
            spriteBatch.Draw(StaticTextures.boardType[currentBoardTypeIndex], boardTypeButtonRec, Color.White);

            spriteBatch.DrawString(StaticFonts.PericlesFont42, "" + numPlayers, new Vector2(1105, numPlayerSelecterRec.Y - 1), Color.Orange,
                         0f, Vector2.Zero, 1, SpriteEffects.None, 0f);
        }

        public void Notify(IOEvent e)
        {
            if (e == startButtonClick)
            {
                RemoveObservers();
                Game1.GameSingleton.StartGame(numPlayers, getCurrentCategory(), getCurrentBoardSize(), getCurrentBoardType());
            }
            else if (e == playerLeftArrowClick)
            {
                changeNumPlayers(-1);
            }
            else if (e == playerRightArrowClick)
            {
                changeNumPlayers(1);
            }
            else if (e == categoryLeftArrowClick)
            {
                changeCategory(-1);
            }
            else if (e == categoryRightArrowClick)
            {
                changeCategory(1);
            }
            else if (e == boardSizeLeftArrowClick)
            {
                changeBoardSize(-1);
            }
            else if (e == boardSizeRightArrowClick)
            {
                changeBoardSize(1);
            }
            else if (e == boardTypeLeftArrowClick)
            {
                changeBoardType(-1);
            }
            else if (e == boardTypeRightArrowClick)
            {
                changeBoardType(1);
            }
        }

        public void changeNumPlayers(int change)
        {
            numPlayers = (numPlayers + GameBoard.maxPlayers + change) % GameBoard.maxPlayers;

            if (numPlayers == 0)
            {
                numPlayers = GameBoard.maxPlayers;
            }
        }

        public void changeCategory(int change)
        {
            currentCategoryIndex = (currentCategoryIndex + QuestionPool.numCategories + change) % QuestionPool.numCategories;
        }

        public void changeBoardSize(int change)
        {
            currentBoardSizeSelectorIndex = (currentBoardSizeSelectorIndex + BoardGenerator.numBoardSizes + change) % BoardGenerator.numBoardSizes;
        }

        public void changeBoardType(int change)
        {
            currentBoardTypeIndex = (currentBoardTypeIndex + BoardGenerator.numBoardTypes + change) % BoardGenerator.numBoardTypes;
        }

        public int getNumPlayers()
        {
            return numPlayers;
        }

        public Category getCurrentCategory()
        {
            if (currentCategoryIndex == 0)
            {
                return Category.VIDEOGAMES;
            }
            else if (currentCategoryIndex == 1)
            {
                return Category.MOVIES;
            }
            else if (currentCategoryIndex == 2)
            {
                return Category.MUSIC;
            }
            else if (currentCategoryIndex == 3)
            {
                return Category.TVSHOWS;
            }
            else
            {
                return Category.NONE;
            }
        }

        public BoardSize getCurrentBoardSize()
        {
            if (currentBoardSizeSelectorIndex == 0)
            {
                return BoardSize.SMALL;
            }
            else if (currentBoardSizeSelectorIndex == 1)
            {
                return BoardSize.MEDIUM;
            }
            else if (currentBoardSizeSelectorIndex == 2)
            {
                return BoardSize.LARGE;
            }
            else
            {
                return BoardSize.NONE;
            }
        }

        public BoardType getCurrentBoardType()
        {
            if (currentBoardTypeIndex == 0)
            {
                return BoardType.STANDARD;
            }
            else if (currentBoardTypeIndex == 1)
            {
                return BoardType.RANDOM;
            }
            else
            {
                return BoardType.NONE;
            }
        }

        public Rectangle GetLeftArrow(Rectangle rec)
        {
            return new Rectangle(rec.X, rec.Y, rec.Width - 162, rec.Height);
        }

        public Rectangle GetRightArrow(Rectangle rec)
        {
            return new Rectangle(rec.X + 162, rec.Y, rec.Width - 162, rec.Height);
        }

        public void Reset()
        {
            numPlayers = 1;
            currentCategoryIndex = 0;
            currentBoardSizeSelectorIndex = 0;
            currentBoardTypeIndex = 0;
        }
    }
}
