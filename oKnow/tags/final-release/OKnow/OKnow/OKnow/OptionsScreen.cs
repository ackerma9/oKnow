using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.UI;
using Microsoft.Xna.Framework;
using OKnow.StaticContent;
using Microsoft.Xna.Framework.Graphics;

namespace OKnow
{
    /// <summary>
    /// Represents the options screen of the game
    /// </summary>
    public class OptionsScreen : IOObserver
    {
        private static OptionsScreen singletonReference = null;

        private Rectangle startImageRec;
        private Rectangle boardSizeButtonRec;
        private Rectangle boardTypeButtonRec;
        private Rectangle standardTileRec;
        private Rectangle timedTileRec;
        private Rectangle musicTileRec;
        private Rectangle imageTileRec;
        private Rectangle deathTileRec;
        private Rectangle jokerTileRec;
        private Rectangle backButtonRec;

        private int currentBoardSizeSelectorIndex;
        private int currentBoardTypeIndex;

        private RectangleLeftClick boardSizeLeftArrowClick;
        private RectangleLeftClick boardSizeRightArrowClick;
        private RectangleLeftClick boardTypeLeftArrowClick;
        private RectangleLeftClick boardTypeRightArrowClick;
        private RectangleLeftClick standardTileLeftArrowClick;
        private RectangleLeftClick standardTileRightArrowClick;
        private RectangleLeftClick timedTileLeftArrowClick;
        private RectangleLeftClick timedTileRightArrowClick;
        private RectangleLeftClick musicTileLeftArrowClick;
        private RectangleLeftClick musicTileRightArrowClick;
        private RectangleLeftClick imageTileLeftArrowClick;
        private RectangleLeftClick imageTileRightArrowClick;
        private RectangleLeftClick deathTileLeftArrowClick;
        private RectangleLeftClick deathTileRightArrowClick;
        private RectangleLeftClick jokerTileLeftArrowClick;
        private RectangleLeftClick jokerTileRightArrowClick;
        private RectangleLeftClick backButtonClick;

        private int[] tileWeights;
        private int weightTotal;

        /// <summary>
        /// Main constructor for the options screen
        /// </summary>
        public OptionsScreen()
        {
            currentBoardSizeSelectorIndex = 0;
            currentBoardTypeIndex = 0;
            tileWeights = new int[] { 10, 3, 3, 3, 2, 2 };
            weightTotal = 23;
            singletonReference = this;
            RectangleHelper();
        }

        /// <summary>
        /// Gets a singleton reference of the options screen
        /// </summary>
        public static OptionsScreen Singleton
        {
            get { return singletonReference; }
        }

        /// <summary>
        /// Adds all the buttons to obsever mouse clicks
        /// </summary>
        public void AddObservers()
        {
            IOSubject.AddObserver(boardSizeLeftArrowClick, this);
            IOSubject.AddObserver(boardSizeRightArrowClick, this);
            IOSubject.AddObserver(boardTypeLeftArrowClick, this);
            IOSubject.AddObserver(boardTypeRightArrowClick, this);
            IOSubject.AddObserver(standardTileLeftArrowClick, this);
            IOSubject.AddObserver(standardTileRightArrowClick, this);
            IOSubject.AddObserver(timedTileLeftArrowClick, this);
            IOSubject.AddObserver(timedTileRightArrowClick, this);
            IOSubject.AddObserver(musicTileLeftArrowClick, this);
            IOSubject.AddObserver(musicTileRightArrowClick, this);
            IOSubject.AddObserver(imageTileLeftArrowClick, this);
            IOSubject.AddObserver(imageTileRightArrowClick, this);
            IOSubject.AddObserver(deathTileLeftArrowClick, this);
            IOSubject.AddObserver(deathTileRightArrowClick, this);
            IOSubject.AddObserver(jokerTileLeftArrowClick, this);
            IOSubject.AddObserver(jokerTileRightArrowClick, this);
            IOSubject.AddObserver(backButtonClick, this);
        }

        /// <summary>
        /// Removes all the buttons from observing when the screen changses
        /// </summary>
        public void RemoveObservers()
        {
            IOSubject.RemoveObserver(this);
        }

        /// <summary>
        /// Helper function for creating button and click rectangles
        /// </summary>
        private void RectangleHelper()
        {
            startImageRec = new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight);
            boardSizeButtonRec = new Rectangle(820, 50, 200, 70);
            boardTypeButtonRec = new Rectangle(1060, 50, 200, 70);
            standardTileRec = new Rectangle(820, 160, 200, 70);
            timedTileRec = new Rectangle(1060, 160, 200, 70);
            musicTileRec = new Rectangle(820, 270, 200, 70);
            imageTileRec = new Rectangle(1060, 270, 200, 70);
            deathTileRec = new Rectangle(820, 380, 200, 70);
            jokerTileRec = new Rectangle(1060, 380, 200, 70);
            backButtonRec = new Rectangle(940, 490, 200, 70);

            boardSizeLeftArrowClick = new RectangleLeftClick(GetLeftArrow(boardSizeButtonRec));
            boardSizeRightArrowClick = new RectangleLeftClick(GetRightArrow(boardSizeButtonRec));
            boardTypeLeftArrowClick = new RectangleLeftClick(GetLeftArrow(boardTypeButtonRec));
            boardTypeRightArrowClick = new RectangleLeftClick(GetRightArrow(boardTypeButtonRec));
            standardTileLeftArrowClick = new RectangleLeftClick(GetLeftArrow(standardTileRec));
            standardTileRightArrowClick = new RectangleLeftClick(GetRightArrow(standardTileRec));
            timedTileLeftArrowClick = new RectangleLeftClick(GetLeftArrow(timedTileRec));
            timedTileRightArrowClick = new RectangleLeftClick(GetRightArrow(timedTileRec));
            musicTileLeftArrowClick = new RectangleLeftClick(GetLeftArrow(musicTileRec));
            musicTileRightArrowClick = new RectangleLeftClick(GetRightArrow(musicTileRec));
            imageTileLeftArrowClick = new RectangleLeftClick(GetLeftArrow(imageTileRec));
            imageTileRightArrowClick = new RectangleLeftClick(GetRightArrow(imageTileRec));
            deathTileLeftArrowClick = new RectangleLeftClick(GetLeftArrow(deathTileRec));
            deathTileRightArrowClick = new RectangleLeftClick(GetRightArrow(deathTileRec));
            jokerTileLeftArrowClick = new RectangleLeftClick(GetLeftArrow(jokerTileRec));
            jokerTileRightArrowClick = new RectangleLeftClick(GetRightArrow(jokerTileRec));
            backButtonClick = new RectangleLeftClick(backButtonRec);
        }

        /// <summary>
        /// Draws the start screen
        /// </summary>
        /// <param name="spriteBatch"> where to draw </param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(StaticTextures.StartImage, startImageRec, Color.White);

            String text = "Options";
            spriteBatch.DrawString(StaticFonts.PericlesFont70, text, new Vector2(20, 100), Color.Orange, 0f,
                Vector2.Zero, 1, SpriteEffects.None, 0f);

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

            spriteBatch.Draw(StaticTextures.BoardSizeSelector[currentBoardSizeSelectorIndex], boardSizeButtonRec, Color.White);
            spriteBatch.Draw(StaticTextures.BoardType[currentBoardTypeIndex], boardTypeButtonRec, Color.White);
            spriteBatch.Draw(StaticTextures.BackButton, backButtonRec, Color.White);

            if (currentBoardTypeIndex == 1)
            {
                spriteBatch.Draw(StaticTextures.NumPlayerSelecter, standardTileRec, Color.White);
                spriteBatch.Draw(StaticTextures.NumPlayerSelecter, timedTileRec, Color.White);
                spriteBatch.Draw(StaticTextures.NumPlayerSelecter, musicTileRec, Color.White);
                spriteBatch.Draw(StaticTextures.NumPlayerSelecter, imageTileRec, Color.White);
                spriteBatch.Draw(StaticTextures.NumPlayerSelecter, deathTileRec, Color.White);
                spriteBatch.Draw(StaticTextures.NumPlayerSelecter, jokerTileRec, Color.White);

                DrawText("Standard Weight", standardTileRec, spriteBatch);
                DrawText("Timed Weight", timedTileRec, spriteBatch);
                DrawText("Music Weight", musicTileRec, spriteBatch);
                DrawText("Image Weight", imageTileRec, spriteBatch);
                DrawText("Death Weight", deathTileRec, spriteBatch);
                DrawText("Joker Weight", jokerTileRec, spriteBatch);

                spriteBatch.DrawString(StaticFonts.PericlesFont42, "" + tileWeights[0], new Vector2(standardTileRec.X + 80, standardTileRec.Y - 1), Color.Orange,
                         0f, Vector2.Zero, 1, SpriteEffects.None, 0f);

                spriteBatch.DrawString(StaticFonts.PericlesFont42, "" + tileWeights[1], new Vector2(timedTileRec.X + 80, timedTileRec.Y - 1), Color.Orange,
                         0f, Vector2.Zero, 1, SpriteEffects.None, 0f);

                spriteBatch.DrawString(StaticFonts.PericlesFont42, "" + tileWeights[2], new Vector2(musicTileRec.X + 80, musicTileRec.Y - 1), Color.Orange,
                         0f, Vector2.Zero, 1, SpriteEffects.None, 0f);

                spriteBatch.DrawString(StaticFonts.PericlesFont42, "" + tileWeights[3], new Vector2(imageTileRec.X + 80, imageTileRec.Y - 1), Color.Orange,
                         0f, Vector2.Zero, 1, SpriteEffects.None, 0f);

                spriteBatch.DrawString(StaticFonts.PericlesFont42, "" + tileWeights[4], new Vector2(deathTileRec.X + 80, deathTileRec.Y - 1), Color.Orange,
                         0f, Vector2.Zero, 1, SpriteEffects.None, 0f);

                spriteBatch.DrawString(StaticFonts.PericlesFont42, "" + tileWeights[5], new Vector2(jokerTileRec.X + 80, jokerTileRec.Y - 1), Color.Orange,
                         0f, Vector2.Zero, 1, SpriteEffects.None, 0f);
            }
        }

        /// <summary>
        /// Helper funtion for drawing text on the screen
        /// </summary>
        /// <param name="text"> the text to draw </param>
        /// <param name="rec"> the rectangle of the button </param>
        /// <param name="spriteBatch"> where to draw </param>
        private void DrawText(String text, Rectangle rec, SpriteBatch spriteBatch)
        {
            Vector2 size = StaticFonts.PericlesFont18.MeasureString(text);
            int x = (int)(rec.X + (rec.Width / 2) - (size.X / 2));
            int y = (int)(rec.Y - size.Y);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, text,
                new Vector2(x, y), Color.Orange);
        }

        /// <summary>
        /// Handles the correct response when a button is clicked
        /// </summary>
        /// <param name="e"> the event that needs to be handled </param>
        public void Notify(IOEvent e)
        {
            if (e == boardSizeLeftArrowClick)
            {
                ChangeBoardSize(-1);
            }
            else if (e == boardSizeRightArrowClick)
            {
                ChangeBoardSize(1);
            }
            else if (e == boardTypeLeftArrowClick)
            {
                ChangeBoardType(-1);
            }
            else if (e == boardTypeRightArrowClick)
            {
                ChangeBoardType(1);
            }
            else if (e == standardTileLeftArrowClick)
            {
                ChangeTileWeight(0, -1);
            }
            else if (e == standardTileRightArrowClick)
            {
                ChangeTileWeight(0, 1);
            }
            else if (e == timedTileLeftArrowClick)
            {
                ChangeTileWeight(1, -1);
            }
            else if (e == timedTileRightArrowClick)
            {
                ChangeTileWeight(1, 1);
            }
            else if (e == musicTileLeftArrowClick)
            {
                ChangeTileWeight(2, -1);
            }
            else if (e == musicTileRightArrowClick)
            {
                ChangeTileWeight(2, 1);
            }
            else if (e == imageTileLeftArrowClick)
            {
                ChangeTileWeight(3, -1);
            }
            else if (e == imageTileRightArrowClick)
            {
                ChangeTileWeight(3, 1);
            }
            else if (e == deathTileLeftArrowClick)
            {
                ChangeTileWeight(4, -1);
            }
            else if (e == deathTileRightArrowClick)
            {
                ChangeTileWeight(4, 1);
            }
            else if (e == jokerTileLeftArrowClick)
            {
                ChangeTileWeight(5, -1);
            }
            else if (e == jokerTileRightArrowClick)
            {
                ChangeTileWeight(5, 1);
            }
            else if (e == backButtonClick)
            {
                Game1.GameSingleton.OptionsScreenBack();
            }
        }

        /// <summary>
        /// Changes the board size
        /// </summary>
        /// <param name="change"> the value to change board size </param>
        public void ChangeBoardSize(int change)
        {
            currentBoardSizeSelectorIndex = (currentBoardSizeSelectorIndex + BoardGenerator.numBoardSizes + change) % BoardGenerator.numBoardSizes;
        }

        /// <summary>
        /// Changes the board type
        /// </summary>
        /// <param name="change"> the value to change board type </param>
        public void ChangeBoardType(int change)
        {
            currentBoardTypeIndex = (currentBoardTypeIndex + BoardGenerator.numBoardTypes + change) % BoardGenerator.numBoardTypes;
        }

        /// <summary>
        /// Changes the tile weight of a given tile type
        /// </summary>
        /// <param name="tileIndex"> the tile index to change </param>
        /// <param name="change"> the value to change the tile weight </param>
        public void ChangeTileWeight(int tileIndex, int change)
        {
            if (weightTotal == 25 && change == 1)
                return;
            else if (weightTotal == 6 && change == -1)
                return;

            if (tileWeights[tileIndex] == 1 && change == -1)
                return;
            else if (tileWeights[tileIndex] == 10 && change == 1)
                return;

            tileWeights[tileIndex] = (tileWeights[tileIndex] + 10 + change) % 10;

            if (tileWeights[tileIndex] == 0)
            {
                tileWeights[tileIndex] = 10;
            }

            weightTotal += change;
        }

        /// <summary>
        /// Getter for the board size
        /// </summary>
        public BoardSize GetCurrentBoardSize()
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

        /// <summary>
        /// Getter for the current board type
        /// </summary>
        public BoardType GetCurrentBoardType()
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

        /// <summary>
        /// Getter for the tile weights
        /// </summary>
        public int[] GetTileWeights()
        {
            return tileWeights;
        }

        /// <summary>
        /// Resets the state of the start screen for making a new game
        /// </summary>
        public void Reset()
        {
            currentBoardSizeSelectorIndex = 0;
            currentBoardTypeIndex = 0;
            tileWeights = new int[] { 10, 3, 3, 3, 2, 2 };
            weightTotal = 23;
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
    }
}
