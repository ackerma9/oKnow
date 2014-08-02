using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.Questions;

namespace OKnow
{
    public class BoardGenerator
    {
        private static Tile startTile = null;
        private static Tile endTile = null;
        private static QuestionPool pool;

        public static Tile[,] generateBoard(GameBoard board, int width, int height)
        {
            return defaultBoard(board, width, height);
        }

        public static Tile[,] defaultBoard(GameBoard board, int width, int height)
        {
            Tile[,] tileArray = new Tile[width, height];

            startTile = new Tile(board, TileType.START, 0, 2);
            tileArray[0, 2] = startTile;
            tileArray[1, 2] = new Tile(board, TileType.STANDARD, 1, 2);
            tileArray[2, 0] = new Tile(board, TileType.MUSIC, 2, 0);
            tileArray[2, 1] = new Tile(board, TileType.TIMED, 2, 1);
            tileArray[2, 2] = new Tile(board, TileType.JOKER, 2, 2);
            tileArray[2, 3] = new Tile(board, TileType.STANDARD, 2, 3);
            tileArray[2, 4] = new Tile(board, TileType.STANDARD, 2, 4);
            tileArray[3, 0] = new Tile(board, TileType.STANDARD, 3, 0);
            tileArray[3, 2] = new Tile(board, TileType.DEATH, 3, 2);
            tileArray[3, 4] = new Tile(board, TileType.MUSIC, 3, 4);
            tileArray[4, 0] = new Tile(board, TileType.EYE, 4, 0);
            tileArray[4, 2] = new Tile(board, TileType.EYE, 4, 2);
            tileArray[4, 4] = new Tile(board, TileType.TIMED, 4, 4);
            tileArray[5, 0] = new Tile(board, TileType.STANDARD, 5, 0);
            tileArray[5, 2] = new Tile(board, TileType.STANDARD, 5, 2);
            tileArray[5, 4] = new Tile(board, TileType.STANDARD, 5, 4);
            tileArray[6, 0] = new Tile(board, TileType.TIMED, 6, 0);
            tileArray[6, 2] = new Tile(board, TileType.MUSIC, 6, 2);
            tileArray[6, 4] = new Tile(board, TileType.EYE, 6, 4);
            tileArray[7, 0] = new Tile(board, TileType.STANDARD, 7, 0);
            tileArray[7, 2] = new Tile(board, TileType.DEATH, 7, 2);
            tileArray[7, 4] = new Tile(board, TileType.STANDARD, 7, 4);
            tileArray[8, 0] = new Tile(board, TileType.MUSIC, 8, 0);
            tileArray[8, 1] = new Tile(board, TileType.STANDARD, 8, 1);
            tileArray[8, 2] = new Tile(board, TileType.STANDARD, 8, 2);
            tileArray[8, 3] = new Tile(board, TileType.TIMED, 8, 3);
            tileArray[8, 4] = new Tile(board, TileType.MUSIC, 8, 4);
            tileArray[9, 2] = new Tile(board, TileType.STANDARD, 9, 2);
            tileArray[10, 2] = new Tile(board, TileType.TIMED, 10, 2);
            tileArray[11, 0] = new Tile(board, TileType.MUSIC, 11, 0);
            tileArray[11, 1] = new Tile(board, TileType.STANDARD, 11, 1);
            tileArray[11, 2] = new Tile(board, TileType.STANDARD, 11, 2);
            tileArray[11, 3] = new Tile(board, TileType.STANDARD, 11, 3);
            tileArray[11, 4] = new Tile(board, TileType.STANDARD, 11, 4);
            tileArray[12, 0] = new Tile(board, TileType.EYE, 12, 0);
            tileArray[12, 2] = new Tile(board, TileType.TIMED, 12, 2);
            tileArray[12, 4] = new Tile(board, TileType.STANDARD, 12, 4);
            tileArray[13, 0] = new Tile(board, TileType.JOKER, 13, 0);
            tileArray[13, 2] = new Tile(board, TileType.STANDARD, 13, 2);
            tileArray[13, 4] = new Tile(board, TileType.TIMED, 13, 4);
            tileArray[14, 0] = new Tile(board, TileType.STANDARD, 14, 0);
            tileArray[14, 2] = new Tile(board, TileType.MUSIC, 14, 2);
            tileArray[14, 4] = new Tile(board, TileType.MUSIC, 14, 4);
            tileArray[15, 0] = new Tile(board, TileType.TIMED, 15, 0);
            tileArray[15, 2] = new Tile(board, TileType.EYE, 15, 2);
            tileArray[15, 4] = new Tile(board, TileType.JOKER, 15, 4);
            tileArray[16, 0] = new Tile(board, TileType.STANDARD, 16, 0);
            tileArray[16, 2] = new Tile(board, TileType.STANDARD, 16, 2);
            tileArray[16, 4] = new Tile(board, TileType.EYE, 16, 4);
            tileArray[17, 0] = new Tile(board, TileType.TIMED, 17, 0);
            tileArray[17, 1] = new Tile(board, TileType.STANDARD, 17, 1);
            tileArray[17, 2] = new Tile(board, TileType.DEATH, 17, 2);
            tileArray[17, 3] = new Tile(board, TileType.STANDARD, 17, 3);
            tileArray[17, 4] = new Tile(board, TileType.TIMED, 17, 4);
            tileArray[18, 2] = new Tile(board, TileType.STANDARD, 18, 2);
            endTile = new Tile(board, TileType.END, 19, 2);
            tileArray[19, 2] = endTile;

            pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);
            MusicQuestions.addQuestions(pool);
            TVShowQuestions.addQuestions(pool);
            VideoGameQuestions.addQuestions(pool);

            tileArray = setTileQuestions(tileArray);
            
            return tileArray;
        }

        private static Tile[,] setTileQuestions(Tile[,] tileArray)
        {
            Random rand = new Random();

            foreach (Tile tile in tileArray)
            {

                if (tile != null && tile != endTile && tile != startTile)
                {
                    int x = tile.BoardX;
                    int y = tile.BoardY;
                    int cat = rand.Next(1, 4);
                    Console.WriteLine("Category type: " + (Category)cat);
                    switch (cat)
                    {
                        case (int)Category.MUSIC:
                            Question musicTemp = pool.getRandQuestion(Category.MUSIC);
                            tile.setQuestion(musicTemp);
                            break;
                        case (int)Category.MOVIES:
                            Question moviesTemp = pool.getRandQuestion(Category.MOVIES);
                            tile.setQuestion(moviesTemp);
                            break;
                        case (int)Category.TVSHOWS:
                            Question tvTemp = pool.getRandQuestion(Category.TVSHOWS);
                            tile.setQuestion(tvTemp);
                            break;
                        case (int)Category.VIDEOGAMES:
                            Question videoTemp = pool.getRandQuestion(Category.VIDEOGAMES);
                            tile.setQuestion(videoTemp);
                            break;
                    }
                }
            }

            return tileArray;
        }

        public static Tile StartTile
        {
            get{return startTile;}
        }

        public static Tile EndTile
        {
            get{return endTile;}
        }
    }
}
