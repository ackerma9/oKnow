using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow;
using OKnow.Board;
using OKnow.Pieces;
using OKnow.Questions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OKnowTest
{
    [TestClass]
    public class ScoreBoardTest
    {
        [TestMethod]
        public void PlayerScoreTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);
            Assert.AreEqual(0, player.totalScore);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, game.CurrentQuestion);

            Assert.AreEqual(25, player.totalScore);
        }

        [TestMethod]
        public void MultiPlayerCorrectScoreTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(3, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;

            // check that no one else got points
            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, game.CurrentQuestion);
            foreach (Player p in game.GameBoard.Players)
                if (p == player)
                    Assert.AreEqual(50, p.totalScore);
                else
                    Assert.AreEqual(0, p.totalScore);
        }

        [TestMethod]
        public void MultiPlayerIncorrectScoreTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(3, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);

            // check that no one got points
            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);
            foreach (Player p in game.GameBoard.Players)
                Assert.AreEqual(0, p.totalScore);
        }

        [TestMethod]
        public void MultiPlayerMultiCorrectScoreTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(4, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player1 = game.CurrentPlayer;

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, game.CurrentQuestion);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            Player player2 = game.CurrentPlayer;
            game.GameState.QuestionAnswered(true, game.CurrentQuestion);

            foreach (Player p in game.GameBoard.Players)
                if (p == player1 || p == player2)
                    Assert.AreEqual(50, p.totalScore);
                else
                    Assert.AreEqual(0, p.totalScore);
        }

        [TestMethod]
        public void MultiPlayerMultiIncorrectScoreTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(4, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);

            foreach (Player p in game.GameBoard.Players)
                Assert.AreEqual(0, p.totalScore);
        }

        [TestMethod]
        public void TwoPlayerSwapTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(2, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, game.CurrentQuestion);

            GameBoard gameBoard = game.GameBoard;

            Assert.IsTrue(gameBoard.Leaderboard[0] == gameBoard.Players[1]);
        }

        [TestMethod]
        public void BackwardsScoresTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(4, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);

            GameBoard gameBoard = game.GameBoard;

            gameBoard.Players[3].totalScore = 100;
            gameBoard.Players[2].totalScore = 50;
            gameBoard.Players[1].totalScore = 25;
            gameBoard.Players[0].totalScore = 0;

            gameBoard.Sort();

            for (int i = 0; i < 4; i++)
                Assert.IsTrue(gameBoard.Leaderboard[i] == gameBoard.Players[3-i]);
        }

        [TestMethod]
        public void MixedScoresTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(4, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);

            GameBoard gameBoard = game.GameBoard;

            gameBoard.Players[2].totalScore = 100;
            gameBoard.Players[1].totalScore = 50;
            gameBoard.Players[3].totalScore = 25;
            gameBoard.Players[0].totalScore = 0;

            gameBoard.Sort();

            Assert.IsTrue(gameBoard.Leaderboard[0] == gameBoard.Players[2]);
            Assert.IsTrue(gameBoard.Leaderboard[1] == gameBoard.Players[1]);
            Assert.IsTrue(gameBoard.Leaderboard[2] == gameBoard.Players[3]);
            Assert.IsTrue(gameBoard.Leaderboard[3] == gameBoard.Players[0]);
        }

        [TestMethod]
        public void SameScorePlayersKeepPosition()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(4, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);

            GameBoard gameBoard = game.GameBoard;

            gameBoard.Players[0].totalScore = 100;
            gameBoard.Players[1].totalScore = 0;
            gameBoard.Players[2].totalScore = 0;
            gameBoard.Players[3].totalScore = 50;

            gameBoard.Sort();

            gameBoard.Players[0].totalScore = 125;

            gameBoard.Sort();

            Assert.IsTrue(gameBoard.Leaderboard[2] == gameBoard.Players[1]);
            Assert.IsTrue(gameBoard.Leaderboard[3] == gameBoard.Players[2]);
        }

        [TestMethod]
        public void ScoredTwoRounds()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(2, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);

            // 1st player wrong, 2nd player right
            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, game.CurrentQuestion);

            GameBoard gameBoard = game.GameBoard;

            Assert.IsTrue(gameBoard.Leaderboard[0] == gameBoard.Players[1]);
            Assert.IsTrue(gameBoard.Leaderboard[1] == gameBoard.Players[0]);

            // 1st player right, 2nd player wrong
            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, game.CurrentQuestion);

            game.GameState.TileClick(BoardGenerator.SecondTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);

            Assert.IsTrue(gameBoard.Leaderboard[0] == gameBoard.Players[1]);
            Assert.IsTrue(gameBoard.Leaderboard[1] == gameBoard.Players[0]);

            // 1st player right, 2nd player wrong
            game.GameState.TileClick(BoardGenerator.SecondTile);
            game.GameState.QuestionAnswered(true, game.CurrentQuestion);

            game.GameState.TileClick(BoardGenerator.SecondTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);

            Assert.IsTrue(gameBoard.Leaderboard[0] == gameBoard.Players[0]);
            Assert.IsTrue(gameBoard.Leaderboard[1] == gameBoard.Players[1]);
            
        }
    }
}
