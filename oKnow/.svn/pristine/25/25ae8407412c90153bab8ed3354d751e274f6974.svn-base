using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Questions;
using OKnow.Pieces;
using OKnow.Board;

namespace OKnow
{
    public enum BoardSize
    {
        NONE = 0,
        SMALL = 1,
        MEDIUM = 2,
        LARGE = 3
    }

    public enum BoardType
    {
        NONE = 0,
        STANDARD = 1,
        RANDOM = 2
    }

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

        public static AbstractTile[,] generateBoard(GameBoard board, int width, int height, BoardSize bs, BoardType bt, int[] tw)
        {
            pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);
            MusicQuestions.addQuestions(pool);
            TVShowQuestions.addQuestions(pool);
            VideoGameQuestions.addQuestions(pool);

            BoardGenerator.tileWeights = tw;

            if (bs == BoardSize.SMALL)
            {
                return SmallBoardGenerator.generateBoard(board, width, height, bt);
            }
            else if (bs == BoardSize.MEDIUM)
            {
                return MediumBoardGenerator.generateBoard(board, width, height, bt);
            }
            else if (bs == BoardSize.LARGE)
            {
                return LargeBoardGenerator.generateBoard(board, width, height, bt);
            }
            else
            {
                return defaultBoard(board, width, height);
            }
        }

        public static StartTile StartTile
        {
            get{return startTile;}
        }

        public static AbstractTile FirstTile
        {
            get { return firstTile; }
        }

        public static AbstractTile SecondTile
        {
            get { return secondTile; }
        }

        public static EndTile EndTile
        {
            get { return endTile; }
        }

        public static AbstractTile[,] defaultBoard(GameBoard board, int width, int height)
        {
            return LargeBoardGenerator.generateBoard(board, width, height, BoardType.STANDARD);
        }

        public static AbstractTile getRandomTile(GameBoard board, int width, int height)
        {
            int index = rand.Next(0, 25);

            if (index >= 0 && index < sum(0))
            {
                return new StandardTile(board, width, height);
            }
            else if (index >= sum(0) && index < sum(1))
            {
                return new TimedTile(board, width, height);
            }
            else if (index >= sum(1) && index < sum(2))
            {
                return new MusicTile(board, width, height);
            }
            else if (index >= sum(2) && index < sum(3))
            {
                return new ImageTile(board, width, height);
            }
            else if (index >= sum(3) && index < sum(4))
            {
                return new DeathTile(board, width, height);
            }
            else if (index >= sum(4) && index < sum(5))
            {
                return new JokerTile(board, width, height);
            }
            else
            {
                return getRandomTile(board, width, height);
            }
        }

        public static int sum(int index)
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
