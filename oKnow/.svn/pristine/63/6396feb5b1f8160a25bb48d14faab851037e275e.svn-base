using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using OKnow.UI;
using OKnow.Questions;
using Microsoft.Xna.Framework;
using OKnow.StaticContent;
using Microsoft.Xna.Framework.Media;
namespace OKnow
{
    /// <summary>
    /// Represents the starting screen of the game
    /// </summary>
    public class StartScreen : IOObserver
    {
        private Rectangle startImageRec;
        private Rectangle startScreenButtonRec;
        private Rectangle numPlayerSelecterRec;
        private Rectangle categoryButtonRec;
        private Rectangle optionsButtonRec;

        private int numPlayers;
        private int currentCategoryIndex;
        private bool alternate;
        

        private RectangleLeftClick startButtonClick;
        private RectangleLeftClick playerLeftArrowClick;
        private RectangleLeftClick playerRightArrowClick;
        private RectangleLeftClick categoryLeftArrowClick;
        private RectangleLeftClick categoryRightArrowClick;
        private RectangleLeftClick optionsButtonClick;

        /// <summary>
        /// Main constructor for the start screen
        /// </summary>
        public StartScreen()
        {
            numPlayers = 1;
            currentCategoryIndex = 0;
            alternate = true;
            
            RectangleHelper();
            AddObservers();
            PlayTheme();
        }

        /// <summary>
        /// Adds all the buttons to obsever mouse clicks
        /// </summary>
        public void AddObservers()
        {
            IOSubject.AddObserver(startButtonClick, this);
            IOSubject.AddObserver(playerLeftArrowClick, this);
            IOSubject.AddObserver(playerRightArrowClick, this);
            IOSubject.AddObserver(categoryLeftArrowClick, this);
            IOSubject.AddObserver(categoryRightArrowClick, this);
            IOSubject.AddObserver(optionsButtonClick, this);
        }

        /// <summary>
        /// Removes all the buttons from observing when the screen changses
        /// </summary>
        public void RemoveObservers()
        {
            IOSubject.RemoveObserver(this);
        }

        public void PlayTheme()
        {
            if (alternate)
            {
                MediaPlayer.Play(StaticSounds.BkTheme);
            }
            else
            {
                MediaPlayer.Play(StaticSounds.SrTheme);
            }

            alternate = !alternate;
        }

        public void StopTheme()
        {
            MediaPlayer.Stop();
        }

        /// <summary>
        /// Helper function for creating button and click rectangles
        /// </summary>
        private void RectangleHelper()
        {
            startImageRec = new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight);
            startScreenButtonRec = new Rectangle(1020, 50, 200, 70);
            numPlayerSelecterRec = new Rectangle(1020, 160, 200, 70);
            categoryButtonRec = new Rectangle(1020, 270, 200, 70);
            optionsButtonRec = new Rectangle(1020, 380, 200, 70);
            optionsButtonRec = new Rectangle(1020, 490, 200, 70);

            startButtonClick = new RectangleLeftClick(startScreenButtonRec);
            playerLeftArrowClick = new RectangleLeftClick(GetLeftArrow(numPlayerSelecterRec));
            playerRightArrowClick = new RectangleLeftClick(GetRightArrow(numPlayerSelecterRec));
            categoryLeftArrowClick = new RectangleLeftClick(GetLeftArrow(categoryButtonRec));
            categoryRightArrowClick = new RectangleLeftClick(GetRightArrow(categoryButtonRec));
            optionsButtonClick = new RectangleLeftClick(optionsButtonRec);
        }

        /// <summary>
        /// Draws the start screen
        /// </summary>
        /// <param name="spriteBatch"> where to draw </param>
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

            spriteBatch.Draw(StaticTextures.StartScreenButton, startScreenButtonRec, Color.White);
            spriteBatch.Draw(StaticTextures.NumPlayerSelecter, numPlayerSelecterRec, Color.White);
            spriteBatch.Draw(StaticTextures.CategoryButtons[currentCategoryIndex], categoryButtonRec, Color.White);
            spriteBatch.Draw(StaticTextures.OptionsButton, optionsButtonRec, Color.White);

            spriteBatch.DrawString(StaticFonts.PericlesFont42, "" + numPlayers, new Vector2(1105, numPlayerSelecterRec.Y - 1), Color.Orange,
                         0f, Vector2.Zero, 1, SpriteEffects.None, 0f);
        }

        /// <summary>
        /// Handles the correct response when a button is clicked
        /// </summary>
        /// <param name="e"> the event that needs to be handled </param>
        public void Notify(IOEvent e)
        {
            if (e == startButtonClick)
            {
                RemoveObservers();
                StopTheme();
                Game1.GameSingleton.StartGame(numPlayers, GetCurrentCategory(), OptionsScreen.Singleton.GetCurrentBoardSize(), 
                    OptionsScreen.Singleton.GetCurrentBoardType(), OptionsScreen.Singleton.GetTileWeights());
            }
            else if (e == playerLeftArrowClick)
            {
                ChangeNumPlayers(-1);
            }
            else if (e == playerRightArrowClick)
            {
                ChangeNumPlayers(1);
            }
            else if (e == categoryLeftArrowClick)
            {
                ChangeCategory(-1);
            }
            else if (e == categoryRightArrowClick)
            {
                ChangeCategory(1);
            }
            else if (e == optionsButtonClick)
            {
                Game1.GameSingleton.OptionsScreenGo();
            }
        }

        /// <summary>
        /// Changes the number of players
        /// </summary>
        /// <param name="change"> the value to change num players </param>
        public void ChangeNumPlayers(int change)
        {
            numPlayers = (numPlayers + GameBoard.maxPlayers + change) % GameBoard.maxPlayers;

            if (numPlayers == 0)
            {
                numPlayers = GameBoard.maxPlayers;
            }
        }

        /// <summary>
        /// Changes the category
        /// </summary>
        /// <param name="change"> the value to change category </param>
        public void ChangeCategory(int change)
        {
            currentCategoryIndex = (currentCategoryIndex + QuestionPool.numCategories + change) % QuestionPool.numCategories;
        }

        /// <summary>
        /// Getter for num players
        /// </summary>
        public int getNumPlayers()
        {
            return numPlayers;
        }

        /// <summary>
        /// Getter for the category Enum
        /// </summary>
        public Category GetCurrentCategory()
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

        /// <summary>
        /// Finds the position of the left arrow inside a button rectangle
        /// </summary>
        /// <param name="rec"> the rectangle of the button </param>
        public Rectangle GetLeftArrow(Rectangle rec)
        {
            return new Rectangle(rec.X, rec.Y, rec.Width - 162, rec.Height);
        }

        /// <summary>
        /// Finds the position of the right arrow inside a button rectangle
        /// </summary>
        /// <param name="rec"> the rectangle of the button </param>
        public Rectangle GetRightArrow(Rectangle rec)
        {
            return new Rectangle(rec.X + 162, rec.Y, rec.Width - 162, rec.Height);
        }

        /// <summary>
        /// Resets the state of the start screen for making a new game
        /// </summary>
        public void Reset()
        {
            numPlayers = 1;
            currentCategoryIndex = 0;
            if (OptionsScreen.Singleton != null)
            {
                OptionsScreen.Singleton.Reset();
            }
        }
    }
}
