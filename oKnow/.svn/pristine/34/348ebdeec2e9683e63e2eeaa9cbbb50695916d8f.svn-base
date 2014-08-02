using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Pieces;

namespace OKnow.Board
{
    /// <summary>
    /// Medium version of the board generator
    /// </summary>
    public class MediumBoardGenerator
    {
        /// <summary>
        /// Generates the medium version of the game board
        /// </summary>
        /// <param name="board"> the game board </param>
        /// <param name="width"> width of the board </param>
        /// <param name="height"> height of the board </param>
        /// <param name="bt"> board type </param>
        public static AbstractTile[,] GenerateBoard(GameBoard board, int width, int height, BoardType bt)
        {
            if (bt == BoardType.RANDOM)
            {
                return MakeMediumRandomBoard(board, width, height);
            }
            else
            {
                return MakeMediumBoard(board, width, height);
            }
        }

        /// <summary>
        /// Generates the standard medium version of the game board
        /// </summary>
        /// <param name="board"> the game board </param>
        /// <param name="width"> width of the board </param>
        /// <param name="height"> height of the board </param>
        public static AbstractTile[,] MakeMediumBoard(GameBoard board, int width, int height)
        {
            AbstractTile[,] tileArray = new AbstractTile[width, height];

            BoardGenerator.startTile = new StartTile(board, 2, 2);
            tileArray[2, 2] = BoardGenerator.startTile;
            tileArray[3, 2] = new StandardTile(board, 3, 2);
            BoardGenerator.firstTile = tileArray[3, 2];
            tileArray[4, 0] = new MusicTile(board, 4, 0);
            tileArray[4, 1] = new TimedTile(board, 4, 1);
            tileArray[4, 2] = new JokerTile(board, 4, 2);
            BoardGenerator.secondTile = tileArray[4, 2];
            tileArray[4, 3] = new StandardTile(board, 4, 3);
            tileArray[4, 4] = new StandardTile(board, 4, 4);
            tileArray[5, 0] = new StandardTile(board, 5, 0);
            tileArray[5, 2] = new DeathTile(board, 5, 2);
            tileArray[5, 4] = new MusicTile(board, 5, 4);
            tileArray[6, 0] = new ImageTile(board, 6, 0);
            tileArray[6, 2] = new ImageTile(board, 6, 2);
            tileArray[6, 4] = new TimedTile(board, 6, 4);
            tileArray[7, 0] = new StandardTile(board, 7, 0);
            tileArray[7, 2] = new StandardTile(board, 7, 2);
            tileArray[7, 4] = new StandardTile(board, 7, 4);
            tileArray[8, 0] = new TimedTile(board, 8, 0);
            tileArray[8, 2] = new MusicTile(board, 8, 2);
            tileArray[8, 4] = new ImageTile(board, 8, 4);
            tileArray[9, 0] = new MusicTile(board, 9, 0);
            tileArray[9, 1] = new StandardTile(board, 9, 1);
            tileArray[9, 2] = new StandardTile(board, 9, 2);
            tileArray[9, 3] = new TimedTile(board, 9, 3);
            tileArray[9, 4] = new MusicTile(board, 9, 4);
            tileArray[10, 0] = new StandardTile(board, 10, 0);
            tileArray[10, 2] = new StandardTile(board, 10, 2);
            tileArray[10, 4] = new StandardTile(board, 10, 4);
            tileArray[11, 0] = new TimedTile(board, 11, 0);
            tileArray[11, 2] = new TimedTile(board, 11, 2);
            tileArray[11, 4] = new TimedTile(board, 11, 4);
            tileArray[12, 0] = new ImageTile(board, 12, 0);
            tileArray[12, 2] = new TimedTile(board, 12, 2);
            tileArray[12, 4] = new StandardTile(board, 12, 4);
            tileArray[13, 0] = new JokerTile(board, 13, 0);
            tileArray[13, 2] = new StandardTile(board, 13, 2);
            tileArray[13, 4] = new TimedTile(board, 13, 4);
            tileArray[14, 0] = new MusicTile(board, 14, 0);
            tileArray[14, 1] = new StandardTile(board, 14, 1);
            tileArray[14, 2] = new StandardTile(board, 14, 2);
            tileArray[14, 3] = new StandardTile(board, 14, 3);
            tileArray[14, 4] = new StandardTile(board, 14, 4);
            tileArray[15, 2] = new StandardTile(board, 15, 2);
            BoardGenerator.endTile = new EndTile(board, 16, 2);
            tileArray[16, 2] = BoardGenerator.endTile;

            return tileArray;
        }

        /// <summary>
        /// Generates the random medium version of the game board
        /// </summary>
        /// <param name="board"> the game board </param>
        /// <param name="width"> width of the board </param>
        /// <param name="height"> height of the board </param>
        public static AbstractTile[,] MakeMediumRandomBoard(GameBoard board, int width, int height)
        {
            AbstractTile[,] tileArray = new AbstractTile[width, height];

            BoardGenerator.startTile = new StartTile(board, 2, 2);
            tileArray[2, 2] = BoardGenerator.startTile;
            tileArray[3, 2] = BoardGenerator.GetRandomTile(board, 3, 2);
            BoardGenerator.firstTile = tileArray[3, 2];
            tileArray[4, 0] = BoardGenerator.GetRandomTile(board, 4, 0);
            tileArray[4, 1] = BoardGenerator.GetRandomTile(board, 4, 1);
            tileArray[4, 2] = BoardGenerator.GetRandomTile(board, 4, 2);
            tileArray[4, 3] = BoardGenerator.GetRandomTile(board, 4, 3);
            tileArray[4, 4] = BoardGenerator.GetRandomTile(board, 4, 4);
            tileArray[5, 0] = BoardGenerator.GetRandomTile(board, 5, 0);
            tileArray[5, 2] = BoardGenerator.GetRandomTile(board, 5, 2);
            tileArray[5, 4] = BoardGenerator.GetRandomTile(board, 5, 4);
            tileArray[6, 0] = BoardGenerator.GetRandomTile(board, 6, 0);
            tileArray[6, 2] = BoardGenerator.GetRandomTile(board, 6, 2);
            tileArray[6, 4] = BoardGenerator.GetRandomTile(board, 6, 4);
            tileArray[7, 0] = BoardGenerator.GetRandomTile(board, 7, 0);
            tileArray[7, 2] = BoardGenerator.GetRandomTile(board, 7, 2);
            tileArray[7, 4] = BoardGenerator.GetRandomTile(board, 7, 4);
            tileArray[8, 0] = BoardGenerator.GetRandomTile(board, 8, 0);
            tileArray[8, 2] = BoardGenerator.GetRandomTile(board, 8, 2);
            tileArray[8, 4] = BoardGenerator.GetRandomTile(board, 8, 4);
            tileArray[9, 0] = BoardGenerator.GetRandomTile(board, 9, 0);
            tileArray[9, 1] = BoardGenerator.GetRandomTile(board, 9, 1);
            tileArray[9, 2] = BoardGenerator.GetRandomTile(board, 9, 2);
            tileArray[9, 3] = BoardGenerator.GetRandomTile(board, 9, 3);
            tileArray[9, 4] = BoardGenerator.GetRandomTile(board, 9, 4);
            tileArray[10, 0] = BoardGenerator.GetRandomTile(board, 10, 0);
            tileArray[10, 2] = BoardGenerator.GetRandomTile(board, 10, 2);
            tileArray[10, 4] = BoardGenerator.GetRandomTile(board, 10, 4);
            tileArray[11, 0] = BoardGenerator.GetRandomTile(board, 11, 0);
            tileArray[11, 2] = BoardGenerator.GetRandomTile(board, 11, 2);
            tileArray[11, 4] = BoardGenerator.GetRandomTile(board, 11, 4);
            tileArray[12, 0] = BoardGenerator.GetRandomTile(board, 12, 0);
            tileArray[12, 2] = BoardGenerator.GetRandomTile(board, 12, 2);
            tileArray[12, 4] = BoardGenerator.GetRandomTile(board, 12, 4);
            tileArray[13, 0] = BoardGenerator.GetRandomTile(board, 13, 0);
            tileArray[13, 2] = BoardGenerator.GetRandomTile(board, 13, 2);
            tileArray[13, 4] = BoardGenerator.GetRandomTile(board, 13, 4);
            tileArray[14, 0] = BoardGenerator.GetRandomTile(board, 14, 0);
            tileArray[14, 1] = BoardGenerator.GetRandomTile(board, 14, 1);
            tileArray[14, 2] = BoardGenerator.GetRandomTile(board, 14, 2);
            tileArray[14, 3] = BoardGenerator.GetRandomTile(board, 14, 3);
            tileArray[14, 4] = BoardGenerator.GetRandomTile(board, 14, 4);
            tileArray[15, 2] = BoardGenerator.GetRandomTile(board, 15, 2);
            BoardGenerator.endTile = new EndTile(board, 16, 2);
            tileArray[16, 2] = BoardGenerator.endTile;

            return tileArray;
        }
    }
}
