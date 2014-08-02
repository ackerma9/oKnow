using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Questions;
using OKnow.Pieces;
using OKnow.Board;

namespace OKnow
{
    /// <summary>
    /// Enum for different sizes of the board
    /// </summary>
    public enum BoardSize
    {
        NONE = 0,
        SMALL = 1,
        MEDIUM = 2,
        LARGE = 3
    }

    /// <summary>
    /// Enum for using either a standard board tile set, or a randomly generated tile set
    /// </summary>
    public enum BoardType
    {
        NONE = 0,
        STANDARD = 1,
        RANDOM = 2
    }

    /// <summary>
    /// Generates the board and its tiles from a set of configuration options
    /// </summary>
    public static class BoardGenerator
    {
        public static int numBoardSizes = 3;
        public static int numBoardTypes = 2;

        public static StartTile startTile = null;
        public static EndTile endTile = null;
        public static AbstractTile firstTile = null;
        public static AbstractTile secondTile = null;
        public static QuestionPool pool;
        private static Random rand = new Random();
        public static int[] tileWeights = new int[] { 10, 3, 3, 3, 2, 2 };

        /// <summary>
        /// Main board generation function that takes the configuration options and calls the respective board generator
        /// </summary>
        /// <param name="board"> the game board </param>
        /// <param name="width"> width of the board </param>
        /// <param name="height"> height of the board </param>
        /// <param name="bs"> given board size </param>
        /// <param name="bt"> given board type </param>
        /// <param name="tw"> given set of tile weights </param>
        public static AbstractTile[,] GenerateBoard(GameBoard board, int width, int height, BoardSize bs, BoardType bt, int[] tw)
        {
            pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);
            MusicQuestions.AddQuestions(pool);
            TVShowQuestions.AddQuestions(pool);
            VideoGameQuestions.AddQuestions(pool);

            BoardGenerator.tileWeights = tw;

            if (bs == BoardSize.SMALL)
            {
                return SmallBoardGenerator.GenerateBoard(board, width, height, bt);
            }
            else if (bs == BoardSize.MEDIUM)
            {
                return MediumBoardGenerator.GenerateBoard(board, width, height, bt);
            }
            else if (bs == BoardSize.LARGE)
            {
                return LargeBoardGenerator.GenerateBoard(board, width, height, bt);
            }
            else
            {
                return DefaultBoard(board, width, height);
            }
        }

        /// <summary>
        /// Getter for the start tile
        /// </summary>
        public static StartTile StartTile
        {
            get{return startTile;}
        }

        /// <summary>
        /// Getter for the first tile
        /// </summary>
        public static AbstractTile FirstTile
        {
            get { return firstTile; }
        }

        /// <summary>
        /// Getter for the second tile
        /// </summary>
        public static AbstractTile SecondTile
        {
            get { return secondTile; }
        }

        /// <summary>
        /// Getter for the end tile
        /// </summary>
        public static EndTile EndTile
        {
            get { return endTile; }
        }

        /// <summary>
        /// Calls the default board generator if not configuration options are given
        /// </summary>
        /// <param name="board"> the game board </param>
        /// <param name="width"> width of the board </param>
        /// <param name="height"> height of the board </param>
        public static AbstractTile[,] DefaultBoard(GameBoard board, int width, int height)
        {
            return LargeBoardGenerator.GenerateBoard(board, width, height, BoardType.STANDARD);
        }

        /// <summary>
        /// Randomly picks a tile type based on a set of tile weights
        /// </summary>
        /// <param name="board"> the game board </param>
        /// <param name="width"> width of the board </param>
        /// <param name="board"> the game board </param>
        /// <param name="width"> width of the board </param>
        /// <param name="height"> height of the board </param>
        public static AbstractTile GetRandomTile(GameBoard board, int width, int height)
        {
            int index = rand.Next(0, 25);

            if (index >= 0 && index < Sum(0))
            {
                return new StandardTile(board, width, height);
            }
            else if (index >= Sum(0) && index < Sum(1))
            {
                return new TimedTile(board, width, height);
            }
            else if (index >= Sum(1) && index < Sum(2))
            {
                return new MusicTile(board, width, height);
            }
            else if (index >= Sum(2) && index < Sum(3))
            {
                return new ImageTile(board, width, height);
            }
            else if (index >= Sum(3) && index < Sum(4))
            {
                return new DeathTile(board, width, height);
            }
            else if (index >= Sum(4) && index < Sum(5))
            {
                return new JokerTile(board, width, height);
            }
            else
            {
                return GetRandomTile(board, width, height);
            }
        }

        /// <summary>
        /// Helper function for getting the sum of tile weights in GetRandomTile
        /// </summary>
        /// <param name="index"> index of the number of positions to sum </param>
        public static int Sum(int index)
        {
            if(index == 0)
            {
                return tileWeights[0];
            }
            else if (index == 1)
            {
                return tileWeights[0] + tileWeights[1];
            }
            else if (index == 2)
            {
                return tileWeights[0] + tileWeights[1] + tileWeights[2];
            }
            else if (index == 3)
            {
                return tileWeights[0] + tileWeights[1] + tileWeights[2] + tileWeights[3];
            }
            else if (index == 4)
            {
                return tileWeights[0] + tileWeights[1] + tileWeights[2] + tileWeights[3] + tileWeights[4];
            }
            else if (index == 5)
            {
                return tileWeights[0] + tileWeights[1] + tileWeights[2] + tileWeights[3] + tileWeights[4] + tileWeights[5];
            }
            else
            {
                return 0;
            }
        }
    }
}
