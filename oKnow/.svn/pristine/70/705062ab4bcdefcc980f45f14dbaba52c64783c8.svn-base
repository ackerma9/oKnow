using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;
using OKnow;
using OKnow.Pieces;
using System.Collections.Generic;

namespace OKnowTest
{
    [TestClass]
    public class AnswerAQuestionTest
    {
        [TestMethod]
        public void PlayerMoveStateTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);

            Question question = pool.getRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);
            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, question);
            Assert.AreEqual(player.getTile(), BoardGenerator.FirstTile);

        }

        [TestMethod]
        public void QuestionNotifyCorrectTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);
            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);


            game.CurrentQuestion.Notify(game.CurrentQuestion.CorrectAnswerEvent);
            Assert.AreEqual(player.getTile(), BoardGenerator.StartTile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.getTile(), BoardGenerator.FirstTile);
        }

        [TestMethod]
        public void QuestionNotifyIncorrectTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);
            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);


            game.CurrentQuestion.Notify(game.CurrentQuestion.IncorrectAnswerEvent);
            Assert.AreEqual(player.getTile(), BoardGenerator.StartTile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.getTile(), BoardGenerator.StartTile);
        }

        [TestMethod]
        public void QuestionNotifyTimedTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);
            Player player = game.CurrentPlayer;

            TimedTile tile = new TimedTile(game.GameBoard, BoardGenerator.StartTile.BoardX, BoardGenerator.StartTile.BoardY +1);

            game.GameState.TileClick(tile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.CorrectAnswerEvent);
            Assert.AreEqual(player.getTile(), BoardGenerator.StartTile);

            Assert.AreEqual(null, game.CurrentQuestion.TimedQuestionTimer);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.getTile(), tile);
        }

        [TestMethod]
        public void QuestionNotifyTimedOutTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);
            Player player = game.CurrentPlayer;

            Assert.AreEqual(player.totalScore, 0);
            TimedTile tile = new TimedTile(game.GameBoard, BoardGenerator.StartTile.BoardX, BoardGenerator.StartTile.BoardY + 1);

            game.GameState.TileClick(tile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.TimedQuestionTimer);
            Assert.AreEqual(player.getTile(), BoardGenerator.StartTile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.getTile(), BoardGenerator.StartTile);
        }

        [TestMethod]
        public void PlayerScoreTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);
            Player player = game.CurrentPlayer;

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);
            Assert.AreEqual(0,player.totalScore);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, game.CurrentQuestion);

            Assert.AreEqual(25,player.totalScore);
        }

        [TestMethod]
        public void MultiPlayerCorrectScoreTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(3, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);
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
            game.StartGame(3, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);

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
            game.StartGame(4, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);
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
            game.StartGame(4, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);

            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(false, game.CurrentQuestion);

            foreach (Player p in game.GameBoard.Players)
                Assert.AreEqual(0, p.totalScore);
        }

        [TestMethod]
        public void TestPlayerScoreParameter()
        {
            List<bool[]> arrays = ParameterValues.Singleton().PlayerScoreArray;
            List<int> answers = ParameterValues.Singleton().PlayerScoreAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                TestPlayerScoreHelper(arrays[i], answers[i]);
            }
        }

        private void TestPlayerScoreHelper(bool[] array, int answer)
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.VIDEOGAMES, BoardSize.SMALL, BoardType.STANDARD);
            Player player = game.CurrentPlayer;

            foreach (bool b in array)
            {
                game.GameState.TileClick(BoardGenerator.FirstTile);
                game.GameState.QuestionAnswered(b, game.CurrentQuestion);
            }

            Assert.AreEqual(answer, player.totalScore);
        }
    }
}
