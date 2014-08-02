using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Pieces;

namespace OKnow.Board
{
    public class SmallBoardGenerator
    {
        public static AbstractTile[,] generateBoard(GameBoard board, int width, int height, BoardType bt)
        {
            if (bt == BoardType.RANDOM)
            {
                return makeSmallRandomBoard(board, width, height);
            }
            else
            {
                return makeSmallBoard(board, width, height);
            }
        }

        public static AbstractTile[,] makeSmallBoard(GameBoard board, int width, int height)
        {
            AbstractTile[,] tileArray = new AbstractTile[width, height];

            BoardGenerator.startTile = new StartTile(board, 4, 2);
            tileArray[4, 2] = BoardGenerator.startTile;
            tileArray[5, 2] = new StandardTile(board, 5, 2);
            BoardGenerator.firstTile = tileArray[5, 2];
            tileArray[6, 1] = new ImageTile(board, 6, 1);
            tileArray[6, 2] = new JokerTile(board, 6, 2);
            tileArray[6, 3] = new TimedTile(board, 6, 3);
            tileArray[7, 1] = new MusicTile(board, 7, 1);
            tileArray[7, 3] = new MusicTile(board, 7, 3);
            tileArray[8, 1] = new TimedTile(board, 8, 1);
            tileArray[8, 3] = new ImageTile(board, 8, 3);
            tileArray[9, 1] = new StandardTile(board, 9, 1);
            tileArray[9, 3] = new StandardTile(board, 9, 3);
            tileArray[10, 1] = new TimedTile(board, 10, 1);
            tileArray[10, 3] = new ImageTile(board, 10, 3);
            tileArray[11, 1] = new MusicTile(board, 11, 1);
            tileArray[11, 3] = new MusicTile(board, 11, 3);
            tileArray[12, 1] = new ImageTile(board, 12, 1);
            tileArray[12, 2] = new DeathTile(board, 12, 2);
            tileArray[12, 3] = new TimedTile(board, 12, 3);
            tileArray[13, 2] = new StandardTile(board, 13, 2);
            tileArray[14, 2] = new DeathTile(board, 14, 2);
            BoardGenerator.endTile = new EndTile(board, 15, 2);
            tileArray[15, 2] = BoardGenerator.endTile;

            return tileArray;
        }

        public static AbstractTile[,] makeSmallRandomBoard(GameBoard board, int width, int height)
        {
            AbstractTile[,] tileArray = new AbstractTile[width, height];

            BoardGenerator.startTile = new StartTile(board, 4, 2);
            tileArray[4, 2] = BoardGenerator.startTile;
            tileArray[5, 2] = BoardGenerator.getRandomTile(board, 5, 2);
            BoardGenerator.firstTile = tileArray[5, 2];
            tileArray[6, 1] = BoardGenerator.getRandomTile(board, 6, 1);
            tileArray[6, 2] = BoardGenerator.getRandomTile(board, 6, 2);
            tileArray[6, 3] = BoardGenerator.getRandomTile(board, 6, 3);
            tileArray[7, 1] = BoardGenerator.getRandomTile(board, 7, 1);
            tileArray[7, 3] = BoardGenerator.getRandomTile(board, 7, 3);
            tileArray[8, 1] = BoardGenerator.getRandomTile(board, 8, 1);
            tileArray[8, 3] = BoardGenerator.getRandomTile(board, 8, 3);
            tileArray[9, 1] = BoardGenerator.getRandomTile(board, 9, 1);
            tileArray[9, 3] = BoardGenerator.getRandomTile(board, 9, 3);
            tileArray[10, 1] = BoardGenerator.getRandomTile(board, 10, 1);
            tileArray[10, 3] = BoardGenerator.getRandomTile(board, 10, 3);
            tileArray[11, 1] = BoardGenerator.getRandomTile(board, 11, 1);
            tileArray[11, 3] = BoardGenerator.getRandomTile(board, 11, 3);
            tileArray[12, 1] = BoardGenerator.getRandomTile(board, 12, 1);
            tileArray[12, 2] = BoardGenerator.getRandomTile(board, 12, 2);
            tileArray[12, 3] = BoardGenerator.getRandomTile(board, 12, 3);
            tileArray[13, 2] = BoardGenerator.getRandomTile(board, 13, 2);
            tileArray[14, 2] = BoardGenerator.getRandomTile(board, 14, 2);
            BoardGenerator.endTile = new EndTile(board, 15, 2);
            tileArray[15, 2] = BoardGenerator.endTile;

            return tileArray;
        }
    }
}
