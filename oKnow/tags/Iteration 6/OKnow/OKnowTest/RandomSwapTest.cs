using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;
using OKnow;
using System.Collections.Generic;

namespace OKnowTest
{
    [TestClass]
    public class RandomSwapTest
    {
        [TestMethod]
        public void RandomSwapStateTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);

            Question question = pool.getRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            game.GameState = new RandomPositionSwapState();
            Assert.AreEqual(game.GameState.GetType(), typeof(PlayerMoveState));
            Assert.AreEqual(game.CurrentPlayer.getTile(), BoardGenerator.startTile);
        }

        [TestMethod]
        public void RandomSwapTestMultiplayerTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);

            Question question = pool.getRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.StartGame(2, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            game.GameBoard.Players[1].setTile(BoardGenerator.FirstTile);

            int currentPlayer = game.GameBoard.Players.IndexOf(game.CurrentPlayer);

            List<OKnow.Pieces.AbstractTile> playerTiles = new List<OKnow.Pieces.AbstractTile>();
            for (int i = 0; i < game.GameBoard.Players.Count; i++)
            {
                playerTiles.Insert(i, game.GameBoard.Players[i].getTile());
            }

            game.GameState = new RandomPositionSwapState();
            Assert.AreEqual(game.GameState.GetType(), typeof(PlayerMoveState));
            Assert.AreNotEqual(game.GameBoard.Players[currentPlayer], game.CurrentPlayer);
            Assert.AreEqual(playerTiles[currentPlayer], game.CurrentPlayer.getTile());
        }
    }
}
