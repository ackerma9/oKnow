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
        public static QuestionPool pool;
        private static Random rand = new Random();

        public static AbstractTile[,] generateBoard(GameBoard board, int width, int height, BoardSize bs, BoardType bt)
        {
            pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);
            MusicQuestions.addQuestions(pool);
            TVShowQuestions.addQuestions(pool);
            VideoGameQuestions.addQuestions(pool);

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
            int index = rand.Next(0, 100);

            if (index >= 0 && index < 50)
            {
                return new StandardTile(board, width, height);
            }
            else if (index >= 50 && index < 63)
            {
                return new TimedTile(board, width, height);
            }
            else if (index >= 63 && index < 76)
            {
                return new MusicTile(board, width, height);
            }
            else if (index >= 76 && index < 89)
            {
                return new ImageTile(board, width, height);
            }
            else if (index >= 89 && index < 95)
            {
                return new DeathTile(board, width, height);
            }
            else
            {
                return new JokerTile(board, width, height);
            }
        }
    }
}
