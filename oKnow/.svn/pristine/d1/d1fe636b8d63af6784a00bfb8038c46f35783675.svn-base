using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.UI;

namespace OKnow
{
    class StartScreen : IOObserver
    {
        private Texture2D startImage;
        private Texture2D startScreenButton;
        private Texture2D numPlayerSelecter;

        private Rectangle startImageRec;
        private Rectangle startScreenButtonRec;
        private Rectangle numPlayerSelecterRec;

        private int numPlayers = 1;
        private SpriteFont periclesFont;

        private RectangleLeftClick startButtonClick;
        private RectangleLeftClick leftArrowCLick;
        private RectangleLeftClick rightArrowClick;

        public StartScreen(Texture2D startImage, Texture2D startScreenButton, Texture2D numPlayerSelecter, SpriteFont periclesFont)
        {
            this.startImage = startImage;
            this.startScreenButton = startScreenButton;
            this.numPlayerSelecter = numPlayerSelecter;
            this.periclesFont = periclesFont;

            RectangleHelper();
            
            IOSubject.AddObserver(startButtonClick, this);
            IOSubject.AddObserver(leftArrowCLick, this);
            IOSubject.AddObserver(rightArrowClick, this);
        }

        private void RectangleHelper()
        {
            startImageRec = new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight);
            startScreenButtonRec = new Rectangle(1020, 70, 200, 70);
            numPlayerSelecterRec = new Rectangle(1020, 170, 200, 70);

            startButtonClick = new RectangleLeftClick(startScreenButtonRec);
            leftArrowCLick = new RectangleLeftClick(GetLeftArrow(numPlayerSelecterRec));
            rightArrowClick = new RectangleLeftClick(GetRightArrow(numPlayerSelecterRec));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(startImage, startImageRec, Color.White);

            spriteBatch.DrawString(periclesFont, "oKnow", new Vector2(50, 208), Color.Orange,
                         -.06f, Vector2.Zero, 5, SpriteEffects.None, 0f);

            spriteBatch.Draw(startScreenButton, startScreenButtonRec, Color.White);
            spriteBatch.Draw(numPlayerSelecter, numPlayerSelecterRec, Color.White);

            spriteBatch.DrawString(periclesFont, "" + numPlayers, new Vector2(1105, 169), Color.Orange,
                         0f, Vector2.Zero, 3, SpriteEffects.None, 0f);
        }

        public void Notify(IOEvent e)
        {
            if (e == startButtonClick)
            {
                Game1.getSingleton().StartGame(numPlayers);
            }
            else if (e == leftArrowCLick)
            {
                numPlayers = (numPlayers + GameBoard.maxPlayers - 1 ) % GameBoard.maxPlayers;
            }
            else if (e == rightArrowClick)
            {
                numPlayers = (numPlayers + GameBoard.maxPlayers + 1) % GameBoard.maxPlayers;
            }

            if (numPlayers == 0)
            {
                numPlayers = GameBoard.maxPlayers;
            }
        }

        private Rectangle GetLeftArrow(Rectangle rec)
        {
            return new Rectangle(rec.X, rec.Y, rec.Width - 132, rec.Height);
        }

        private Rectangle GetRightArrow(Rectangle rec)
        {
            return new Rectangle(rec.X + 132, rec.Y, rec.Width - 132, rec.Height);
        }
    }
}
