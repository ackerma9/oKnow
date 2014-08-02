using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Questions;
using OKnow;

namespace OKnowTest
{
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

            setupNumPlayersParameters();
            setupCategoryParameters();
            setupBoardSizeParameters();
            setupBoardTypeParameters();
            setupPlayerScoreParameters();
        }

        public static ParameterValues Singleton()
        {
            if (singleton == null)
            {
                singleton = new ParameterValues();
            }

            return singleton;
        }

        public List<int[]> NumPlayersArray
        {
            get { return numPlayersArray; }
        }

        public List<int> NumPlayersAnswer
        {
            get { return numPlayersAnswer; }
        }

        public List<int[]> CategoryArray
        {
            get { return categoryArray; }
        }

        public List<Category> CategoryAnswer
        {
            get { return categoryAnswer; }
        }

        public List<int[]> BoardSizeArray
        {
            get { return boardSizeArray; }
        }

        public List<BoardSize> BoardSizeAnswer
        {
            get { return boardSizeAnswer; }
        }

        public List<int[]> BoardTypeArray
        {
            get { return boardTypeArray; }
        }

        public List<BoardType> BoardTypeAnswer
        {
            get { return boardTypeAnswer; }
        }

        public List<bool[]> PlayerScoreArray
        {
            get { return playerScoreArray; }
        }

        public List<int> PlayerScoreAnswer
        {
            get { return playerScoreAnswer; }
        }

        private void setupNumPlayersParameters()
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

        private void setupCategoryParameters()
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

        private void setupBoardSizeParameters()
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

        private void setupBoardTypeParameters()
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

        private void setupPlayerScoreParameters()
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
    }
}
