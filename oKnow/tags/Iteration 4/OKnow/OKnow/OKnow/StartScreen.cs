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

        private int numPlayers = 1;
        private int currentCategoryIndex;

        private RectangleLeftClick startButtonClick;
        private RectangleLeftClick playerLeftArrowClick;
        private RectangleLeftClick playerRightArrowClick;
        private RectangleLeftClick categoryLeftArrowClick;
        private RectangleLeftClick categoryRightArrowClick;

        public StartScreen()
        {
            currentCategoryIndex = 0;
            RectangleHelper();
            
            IOSubject.AddObserver(startButtonClick, this);
            IOSubject.AddObserver(playerLeftArrowClick, this);
            IOSubject.AddObserver(playerRightArrowClick, this);
            IOSubject.AddObserver(categoryLeftArrowClick, this);
            IOSubject.AddObserver(categoryRightArrowClick, this);
        }

        private void RectangleHelper()
        {
            startImageRec = new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight);
            startScreenButtonRec = new Rectangle(1020, 70, 200, 70);
            numPlayerSelecterRec = new Rectangle(1020, 170, 200, 70);
            categoryButtonRec = new Rectangle(1020, 270, 200, 70);

            startButtonClick = new RectangleLeftClick(startScreenButtonRec);
            playerLeftArrowClick = new RectangleLeftClick(GetPlayerLeftArrow(numPlayerSelecterRec));
            playerRightArrowClick = new RectangleLeftClick(GetPlayerRightArrow(numPlayerSelecterRec));
            categoryLeftArrowClick = new RectangleLeftClick(GetCategoryLeftArrow(categoryButtonRec));
            categoryRightArrowClick = new RectangleLeftClick(GetCategoryRightArrow(categoryButtonRec));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(StaticTextures.StartImage, startImageRec, Color.White);

            String text = "oKnow";
            Vector2 textSize = StaticFonts.PericlesFont70.MeasureString(text);
            spriteBatch.DrawString(StaticFonts.PericlesFont70, text, new Vector2(20, 100), Color.Orange, 0f,
                Vector2.Zero, 1, SpriteEffects.None, 0f);

            spriteBatch.Draw(StaticTextures.StartScreenButton, startScreenButtonRec, Color.White);
            spriteBatch.Draw(StaticTextures.NumPlayerSelecter, numPlayerSelecterRec, Color.White);
            spriteBatch.Draw(StaticTextures.categoryButtons[currentCategoryIndex], categoryButtonRec, Color.White);

            spriteBatch.DrawString(StaticFonts.PericlesFont42, "" + numPlayers, new Vector2(1105, 169), Color.Orange,
                         0f, Vector2.Zero, 1, SpriteEffects.None, 0f);
        }

        public void Notify(IOEvent e)
        {
            if (e == startButtonClick)
            {
                Game1.GameSingleton.StartGame(numPlayers, getCurrentCategory());
            }
            else if (e == playerLeftArrowClick)
            {
                numPlayers = (numPlayers + GameBoard.maxPlayers - 1 ) % GameBoard.maxPlayers;
            }
            else if (e == playerRightArrowClick)
            {
                numPlayers = (numPlayers + GameBoard.maxPlayers + 1) % GameBoard.maxPlayers;
            }
            else if (e == categoryLeftArrowClick)
            {
                currentCategoryIndex = (currentCategoryIndex + QuestionPool.numCategories - 1) % QuestionPool.numCategories;
            }
            else if (e == categoryRightArrowClick)
            {
                currentCategoryIndex = (currentCategoryIndex + QuestionPool.numCategories + 1) % QuestionPool.numCategories;
            }

            if (numPlayers == 0)
            {
                numPlayers = GameBoard.maxPlayers;
            }
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

        public Rectangle GetPlayerLeftArrow(Rectangle rec)
        {
            return new Rectangle(rec.X, rec.Y, rec.Width - 132, rec.Height);
        }

        public Rectangle GetPlayerRightArrow(Rectangle rec)
        {
            return new Rectangle(rec.X + 132, rec.Y, rec.Width - 132, rec.Height);
        }

        public Rectangle GetCategoryLeftArrow(Rectangle rec)
        {
            return new Rectangle(rec.X, rec.Y, rec.Width - 162, rec.Height);
        }

        public Rectangle GetCategoryRightArrow(Rectangle rec)
        {
            return new Rectangle(rec.X + 162, rec.Y, rec.Width - 162, rec.Height);
        }
    }
}
