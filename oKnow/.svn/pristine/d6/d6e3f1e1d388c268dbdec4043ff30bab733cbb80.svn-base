using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Questions;
using OKnow.Pieces;

namespace OKnow
{
    public class BoardGenerator
    {
        private static StartTile startTile = null;
        private static EndTile endTile = null;
        private static AbstractTile firstTile = null;
        public static QuestionPool pool;

        public static AbstractTile[,] generateBoard(GameBoard board, int width, int height)
        {
            return defaultBoard(board, width, height);
        }

        public static AbstractTile[,] defaultBoard(GameBoard board, int width, int height)
        {
            AbstractTile[,] tileArray = new AbstractTile[width, height];

            startTile = new StartTile(board, 0, 2);
            tileArray[0, 2] = startTile;
            tileArray[1, 2] = new ImageTile(board, 1, 2);
            firstTile = tileArray[1, 2];
            tileArray[2, 0] = new MusicTile(board, 2, 0);
            tileArray[2, 1] = new TimedTile(board, 2, 1);
            tileArray[2, 2] = new JokerTile(board, 2, 2);
            tileArray[2, 3] = new StandardTile(board, 2, 3);
            tileArray[2, 4] = new StandardTile(board, 2, 4);
            tileArray[3, 0] = new StandardTile(board, 3, 0);
            tileArray[3, 2] = new DeathTile(board, 3, 2);
            tileArray[3, 4] = new MusicTile(board, 3, 4);
            tileArray[4, 0] = new ImageTile(board, 4, 0);
            tileArray[4, 2] = new ImageTile(board, 4, 2);
            tileArray[4, 4] = new TimedTile(board, 4, 4);
            tileArray[5, 0] = new StandardTile(board, 5, 0);
            tileArray[5, 2] = new StandardTile(board, 5, 2);
            tileArray[5, 4] = new StandardTile(board, 5, 4);
            tileArray[6, 0] = new TimedTile(board, 6, 0);
            tileArray[6, 2] = new MusicTile(board, 6, 2);
            tileArray[6, 4] = new ImageTile(board, 6, 4);
            tileArray[7, 0] = new StandardTile(board, 7, 0);
            tileArray[7, 2] = new DeathTile(board, 7, 2);
            tileArray[7, 4] = new StandardTile(board, 7, 4);
            tileArray[8, 0] = new MusicTile(board, 8, 0);
            tileArray[8, 1] = new StandardTile(board, 8, 1);
            tileArray[8, 2] = new StandardTile(board, 8, 2);
            tileArray[8, 3] = new TimedTile(board, 8, 3);
            tileArray[8, 4] = new MusicTile(board, 8, 4);
            tileArray[9, 2] = new StandardTile(board, 9, 2);
            tileArray[10, 2] = new TimedTile(board, 10, 2);
            tileArray[11, 0] = new MusicTile(board, 11, 0);
            tileArray[11, 1] = new StandardTile(board, 11, 1);
            tileArray[11, 2] = new StandardTile(board, 11, 2);
            tileArray[11, 3] = new StandardTile(board, 11, 3);
            tileArray[11, 4] = new StandardTile(board, 11, 4);
            tileArray[12, 0] = new ImageTile(board, 12, 0);
            tileArray[12, 2] = new TimedTile(board, 12, 2);
            tileArray[12, 4] = new StandardTile(board, 12, 4);
            tileArray[13, 0] = new JokerTile(board, 13, 0);
            tileArray[13, 2] = new StandardTile(board, 13, 2);
            tileArray[13, 4] = new TimedTile(board, 13, 4);
            tileArray[14, 0] = new StandardTile(board, 14, 0);
            tileArray[14, 2] = new MusicTile(board, 14, 2);
            tileArray[14, 4] = new MusicTile(board, 14, 4);
            tileArray[15, 0] = new TimedTile(board, 15, 0);
            tileArray[15, 2] = new ImageTile(board, 15, 2);
            tileArray[15, 4] = new JokerTile(board, 15, 4);
            tileArray[16, 0] = new StandardTile(board, 16, 0);
            tileArray[16, 2] = new StandardTile(board, 16, 2);
            tileArray[16, 4] = new ImageTile(board, 16, 4);
            tileArray[17, 0] = new TimedTile(board, 17, 0);
            tileArray[17, 1] = new StandardTile(board, 17, 1);
            tileArray[17, 2] = new DeathTile(board, 17, 2);
            tileArray[17, 3] = new StandardTile(board, 17, 3);
            tileArray[17, 4] = new TimedTile(board, 17, 4);
            tileArray[18, 2] = new StandardTile(board, 18, 2);
            endTile = new EndTile(board, 19, 2);
            tileArray[19, 2] = endTile;

            pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);
            MusicQuestions.addQuestions(pool);
            TVShowQuestions.addQuestions(pool);
            VideoGameQuestions.addQuestions(pool);
            
            return tileArray;
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
    }
}
