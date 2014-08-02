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
		/// <summary>
        /// Tests swapping for one player
        ///</summary>	
        [TestMethod]
        public void RandomSwapStateTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);

            Question question = pool.GetRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            game.GameState = new RandomPositionSwapState();
            Assert.AreEqual(game.GameState.GetType(), typeof(PlayerMoveState));
            Assert.AreEqual(game.CurrentPlayer.GetTile(), BoardGenerator.startTile);
        }
		/// <summary>
        /// Tests swapping for multiple players
        ///</summary>
        [TestMethod]
        public void RandomSwapTestMultiplayerTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);

            Question question = pool.GetRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.StartGame(2, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            game.GameBoard.Players[1].SetTile(BoardGenerator.FirstTile);

            int currentPlayer = game.GameBoard.Players.IndexOf(game.CurrentPlayer);

            List<OKnow.Pieces.AbstractTile> playerTiles = new List<OKnow.Pieces.AbstractTile>();
            for (int i = 0; i < game.GameBoard.Players.Count; i++)
            {
                playerTiles.Insert(i, game.GameBoard.Players[i].GetTile());
            }

            game.GameState = new RandomPositionSwapState();
            Assert.AreEqual(game.GameState.GetType(), typeof(PlayerMoveState));
            Assert.AreNotEqual(game.GameBoard.Players[currentPlayer], game.CurrentPlayer);
            Assert.AreEqual(playerTiles[currentPlayer], game.CurrentPlayer.GetTile());
        }
    }
}
