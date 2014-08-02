using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Questions;
using OKnow;
using Microsoft.Xna.Framework;

namespace OKnowTest
{
    /// <summary>
    /// Advanced testing using parameter passing
    /// </summary>
    public class ParameterValues
    {
        private static ParameterValues singleton;

        private List<int[]> numPlayersArray;
        private List<int> numPlayersAnswer;

        private List<int[]> categoryArray;
        private List<Category> categoryAnswer;

        private List<int[]> boardSizeArray;
        private List<BoardSize> boardSizeAnswer;

        private List<int[]> boardTypeArray;
        private List<BoardType> boardTypeAnswer;

        private List<bool[]> playerScoreArray;
        private List<int> playerScoreAnswer;

        private List<Rectangle> leftArrowParam;
        private List<Rectangle> leftArrowAnswer;

        private List<Rectangle> rightArrowParam;
        private List<Rectangle> rightArrowAnswer;

        private List<int[]> tileWeightArray;
        private List<int> tileWeightAnswer;

        /// <summary>
        /// Initializes the parameters
        /// </summary>
        public ParameterValues()
        {
            numPlayersArray = new List<int[]>();
            numPlayersAnswer = new List<int>();

            categoryArray = new List<int[]>();
            categoryAnswer = new List<Category>();

            boardSizeArray = new List<int[]>();
            boardSizeAnswer = new List<BoardSize>();

            boardTypeArray = new List<int[]>();
            boardTypeAnswer = new List<BoardType>();

            playerScoreArray = new List<bool[]>();
            playerScoreAnswer = new List<int>();

            leftArrowParam = new List<Rectangle>();
            leftArrowAnswer = new List<Rectangle>();

            rightArrowParam = new List<Rectangle>();
            rightArrowAnswer = new List<Rectangle>();

            tileWeightArray = new List<int[]>();
            tileWeightAnswer = new List<int>();

            SetupNumPlayersParameters();
            SetupCategoryParameters();
            SetupBoardSizeParameters();
            SetupBoardTypeParameters();
            SetupPlayerScoreParameters();
            SetupLeftArrowParameters();
            SetupRightArrowParameters();
            SetupTileWeightParameters();
        }

        /// <summary>
        /// Singleton reference for the parameters
        /// </summary>
        public static ParameterValues Singleton()
        {
            if (singleton == null)
            {
                singleton = new ParameterValues();
            }

            return singleton;
        }

        /// <summary>
        /// Getter for numPlayersArray
        /// </summary>
        public List<int[]> NumPlayersArray
        {
            get { return numPlayersArray; }
        }

        /// <summary>
        /// Getter for NumPlayersAnswer
        /// </summary>
        public List<int> NumPlayersAnswer
        {
            get { return numPlayersAnswer; }
        }

        /// <summary>
        /// Getter for CategoryArray
        /// </summary>
        public List<int[]> CategoryArray
        {
            get { return categoryArray; }
        }

        /// <summary>
        /// Getter for CategoryAnswer
        /// </summary>
        public List<Category> CategoryAnswer
        {
            get { return categoryAnswer; }
        }

        /// <summary>
        /// Getter for BoardSizeArray
        /// </summary>
        public List<int[]> BoardSizeArray
        {
            get { return boardSizeArray; }
        }

        /// <summary>
        /// Getter for BoardSizeAnswer
        /// </summary>
        public List<BoardSize> BoardSizeAnswer
        {
            get { return boardSizeAnswer; }
        }

        /// <summary>
        /// Getter for BoardTypeArray
        /// </summary>
        public List<int[]> BoardTypeArray
        {
            get { return boardTypeArray; }
        }

        /// <summary>
        /// Getter for BoardTypeAnswer
        /// </summary>
        public List<BoardType> BoardTypeAnswer
        {
            get { return boardTypeAnswer; }
        }

        /// <summary>
        /// Getter for PlayerScoreArray
        /// </summary>
        public List<bool[]> PlayerScoreArray
        {
            get { return playerScoreArray; }
        }

        /// <summary>
        /// Getter for PlayerScoreAnswer
        /// </summary>
        public List<int> PlayerScoreAnswer
        {
            get { return playerScoreAnswer; }
        }

        /// <summary>
        /// Getter for LeftArrowParam
        /// </summary>
        public List<Rectangle> LeftArrowParam
        {
            get { return leftArrowParam; }
        }

        /// <summary>
        /// Getter for LeftArrowAnswer
        /// </summary>
        public List<Rectangle> LeftArrowAnswer
        {
            get { return leftArrowAnswer; }
        }

        /// <summary>
        /// Getter for RightArrowParam
        /// </summary>
        public List<Rectangle> RightArrowParam
        {
            get { return rightArrowParam; }
        }

        /// <summary>
        /// Getter for RightArrowAnswer
        /// </summary>
        public List<Rectangle> RightArrowAnswer
        {
            get { return rightArrowAnswer; }
        }

        /// <summary>
        /// Getter for TileWeightArray
        /// </summary>
        public List<int[]> TileWeightArray
        {
            get { return tileWeightArray; }
        }

        /// <summary>
        /// Getter for TileWeightAnswer
        /// </summary>
        public List<int> TileWeightAnswer
        {
            get { return tileWeightAnswer; }
        }

        /// <summary>
        /// Creates parameter values
        /// </summary>
        private void SetupNumPlayersParameters()
        {
            numPlayersArray.Add(new int[] { });
            numPlayersAnswer.Add(1);

            numPlayersArray.Add(new int[] { 1 });
            numPlayersAnswer.Add(2);

            numPlayersArray.Add(new int[] { 1, 1 });
            numPlayersAnswer.Add(3);

            numPlayersArray.Add(new int[] { 1, 1, 1 });
            numPlayersAnswer.Add(4);

            numPlayersArray.Add(new int[] { -1 });
            numPlayersAnswer.Add(4);

            numPlayersArray.Add(new int[] { 1, -1, 1, 1 });
            numPlayersAnswer.Add(3);

            numPlayersArray.Add(new int[] { -1, -1 });
            numPlayersAnswer.Add(3);

            numPlayersArray.Add(new int[] { -1, 1, -1 });
            numPlayersAnswer.Add(4);
        }

        /// <summary>
        /// Creates parameter values
        /// </summary>
        private void SetupCategoryParameters()
        {
            categoryArray.Add(new int[] { });
            categoryAnswer.Add(Category.VIDEOGAMES);

            categoryArray.Add(new int[] { 1 });
            categoryAnswer.Add(Category.MOVIES);

            categoryArray.Add(new int[] { 1, 1 });
            categoryAnswer.Add(Category.MUSIC);

            categoryArray.Add(new int[] { 1, 1, 1 });
            categoryAnswer.Add(Category.TVSHOWS);

            categoryArray.Add(new int[] { -1 });
            categoryAnswer.Add(Category.TVSHOWS);

            categoryArray.Add(new int[] { 1, -1, 1, 1 });
            categoryAnswer.Add(Category.MUSIC);

            categoryArray.Add(new int[] { -1, -1 });
            categoryAnswer.Add(Category.MUSIC);

            categoryArray.Add(new int[] { -1, 1, -1 });
            categoryAnswer.Add(Category.TVSHOWS);
        }

        /// <summary>
        /// Creates parameter values
        /// </summary>
        private void SetupBoardSizeParameters()
        {
            boardSizeArray.Add(new int[] { });
            boardSizeAnswer.Add(BoardSize.SMALL);

            boardSizeArray.Add(new int[] { 1 });
            boardSizeAnswer.Add(BoardSize.MEDIUM);

            boardSizeArray.Add(new int[] { 1, 1 });
            boardSizeAnswer.Add(BoardSize.LARGE);

            boardSizeArray.Add(new int[] { 1, 1, 1 });
            boardSizeAnswer.Add(BoardSize.SMALL);

            boardSizeArray.Add(new int[] { -1 });
            boardSizeAnswer.Add(BoardSize.LARGE);

            boardSizeArray.Add(new int[] { -1, 1, 1 });
            boardSizeAnswer.Add(BoardSize.MEDIUM);

            boardSizeArray.Add(new int[] { -1, -1 });
            boardSizeAnswer.Add(BoardSize.MEDIUM);

            boardSizeArray.Add(new int[] { -1, 1, -1 });
            boardSizeAnswer.Add(BoardSize.LARGE);
        }

        /// <summary>
        /// Creates parameter values
        /// </summary>
        private void SetupBoardTypeParameters()
        {
            boardTypeArray.Add(new int[] { });
            boardTypeAnswer.Add(BoardType.STANDARD);

            boardTypeArray.Add(new int[] { 1 });
            boardTypeAnswer.Add(BoardType.RANDOM);

            boardTypeArray.Add(new int[] { 1, 1 });
            boardTypeAnswer.Add(BoardType.STANDARD);

            boardTypeArray.Add(new int[] { -1 });
            boardTypeAnswer.Add(BoardType.RANDOM);

            boardTypeArray.Add(new int[] { 1, -1, 1 });
            boardTypeAnswer.Add(BoardType.RANDOM);

            boardTypeArray.Add(new int[] { -1, -1 });
            boardTypeAnswer.Add(BoardType.STANDARD);

            boardTypeArray.Add(new int[] { -1, 1, -1 });
            boardTypeAnswer.Add(BoardType.RANDOM);
        }

        /// <summary>
        /// Creates parameter values
        /// </summary>
        private void SetupPlayerScoreParameters()
        {
            playerScoreArray.Add(new bool[] { });
            playerScoreAnswer.Add(0);

            playerScoreArray.Add(new bool[] { true});
            playerScoreAnswer.Add(50);

            playerScoreArray.Add(new bool[] { false, true});
            playerScoreAnswer.Add(25);

            playerScoreArray.Add(new bool[] { false, false, true});
            playerScoreAnswer.Add(16);

            playerScoreArray.Add(new bool[] { false, false, false, true});
            playerScoreAnswer.Add(5);
        }

        /// <summary>
        /// Creates parameter values
        /// </summary>
        private void SetupLeftArrowParameters()
        {
            leftArrowParam.Add(new Rectangle(0, 0, 200, 200));
            leftArrowAnswer.Add(new Rectangle(0, 0, 38, 200));

            leftArrowParam.Add(new Rectangle(0, 0, 400, 400));
            leftArrowAnswer.Add(new Rectangle(0, 0, 238, 400));

            leftArrowParam.Add(new Rectangle(100, 100, 200, 200));
            leftArrowAnswer.Add(new Rectangle(100, 100, 38, 200));

            leftArrowParam.Add(new Rectangle(100, 100, 400, 400));
            leftArrowAnswer.Add(new Rectangle(100, 100, 238, 400));

            leftArrowParam.Add(new Rectangle(200, 200, 500, 500));
            leftArrowAnswer.Add(new Rectangle(200, 200, 338, 500));
        }

        /// <summary>
        /// Creates parameter values
        /// </summary>
        private void SetupRightArrowParameters()
        {
            rightArrowParam.Add(new Rectangle(0, 0, 200, 200));
            rightArrowAnswer.Add(new Rectangle(162, 0, 38, 200));

            rightArrowParam.Add(new Rectangle(0, 0, 400, 400));
            rightArrowAnswer.Add(new Rectangle(162, 0, 238, 400));

            rightArrowParam.Add(new Rectangle(100, 100, 200, 200));
            rightArrowAnswer.Add(new Rectangle(262, 100, 38, 200));

            rightArrowParam.Add(new Rectangle(100, 100, 400, 400));
            rightArrowAnswer.Add(new Rectangle(262, 100, 238, 400));

            rightArrowParam.Add(new Rectangle(200, 200, 500, 500));
            rightArrowAnswer.Add(new Rectangle(362, 200, 338, 500));
        }

        /// <summary>
        /// Creates parameter values
        /// </summary>
        private void SetupTileWeightParameters()
        {
            tileWeightArray.Add(new int[] { });
            tileWeightAnswer.Add(10);

            tileWeightArray.Add(new int[] { 1 });
            tileWeightAnswer.Add(10);

            tileWeightArray.Add(new int[] { -1 });
            tileWeightAnswer.Add(9);

            tileWeightArray.Add(new int[] { -1, -1 });
            tileWeightAnswer.Add(8);

            tileWeightArray.Add(new int[] { -1, 1 });
            tileWeightAnswer.Add(10);

            tileWeightArray.Add(new int[] { -1, -1, -1, -1});
            tileWeightAnswer.Add(6);

            tileWeightArray.Add(new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 });
            tileWeightAnswer.Add(1);

            tileWeightArray.Add(new int[] { -1, -1, -1, -1, -1, -1, 1, 1, 1 });
            tileWeightAnswer.Add(7);
        }
    }
}
