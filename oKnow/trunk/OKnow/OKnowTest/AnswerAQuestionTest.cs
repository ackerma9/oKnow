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
		/// <summary>
        ///Tests players move state
        ///</summary>
        public void PlayerMoveStateTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);

            Question question = pool.GetRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, question);
            Assert.AreEqual(player.GetTile(), BoardGenerator.FirstTile);

        }

		/// <summary>
        /// Tests the notify for correct question clicks
        ///</summary>
        [TestMethod]
        public void QuestionNotifyCorrectClickTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);


            game.CurrentQuestion.Notify(game.CurrentQuestion.CorrectAnswerClickEvent);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.GetTile(), BoardGenerator.FirstTile);
        }
		/// <summary>
        /// Tests the notify for incorrect question clicks
        ///</summary>

        [TestMethod]
        public void QuestionNotifyIncorrectClickTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);


            game.CurrentQuestion.Notify(game.CurrentQuestion.IncorrectAnswerClickEvent);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);
        }
		/// <summary>
        /// Tests the notify for timed question clicks
        ///</summary>

        [TestMethod]
        public void QuestionNotifyTimedClickTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;

            TimedTile tile = new TimedTile(game.GameBoard, BoardGenerator.StartTile.BoardX, BoardGenerator.StartTile.BoardY +1);

            game.GameState.TileClick(tile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.CorrectAnswerClickEvent);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);

            Assert.AreEqual(null, game.CurrentQuestion.TimedQuestionTimer);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.GetTile(), tile);
        }
		/// <summary>
        /// Tests the question timer time out
        ///</summary>

        [TestMethod]
        public void QuestionNotifyTimedOutTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;

            Assert.AreEqual(player.totalScore, 0);
            TimedTile tile = new TimedTile(game.GameBoard, BoardGenerator.StartTile.BoardX, BoardGenerator.StartTile.BoardY + 1);

            game.GameState.TileClick(tile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.TimedQuestionTimer);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);
        }
		/// <summary>
        /// Tests to make sure player score is accurate
        ///</summary>

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
		/// <summary>
        /// Helper for test  player score.
        ///</summary>
        private void TestPlayerScoreHelper(bool[] array, int answer)
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.VIDEOGAMES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;

            foreach (bool b in array)
            {
                game.GameState.TileClick(BoardGenerator.FirstTile);
                game.GameState.QuestionAnswered(b, game.CurrentQuestion);
            }

            Assert.AreEqual(answer, player.totalScore);
        }
		/// <summary>
        /// Tests the key input for answering questions
        ///</summary>
        [TestMethod]
        public void QuestionNotifyCorrectKeyTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);


            game.CurrentQuestion.Notify(game.CurrentQuestion.CorrectAnswerKeyEvent);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.GetTile(), BoardGenerator.FirstTile);
        }
		/// <summary>
        /// Tests the key input for answering questions
        ///</summary>
        [TestMethod]
        public void QuestionNotifyIncorrectKeyTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);


            game.CurrentQuestion.Notify(game.CurrentQuestion.IncorrectAnswerKeyEvent);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);
        }
		/// <summary>
        /// Tests the key input for answering timed questions
        ///</summary>
        [TestMethod]
        public void QuestionNotifyTimedKeyTest()
        {
            Game1 game = new Game1();
            game.GameState = new PlayerMoveState();
            game.StartGame(1, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = game.CurrentPlayer;

            TimedTile tile = new TimedTile(game.GameBoard, BoardGenerator.StartTile.BoardX, BoardGenerator.StartTile.BoardY + 1);

            game.GameState.TileClick(tile);

            game.CurrentQuestion.Notify(game.CurrentQuestion.CorrectAnswerKeyEvent);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);

            Assert.AreEqual(null, game.CurrentQuestion.TimedQuestionTimer);

            game.CurrentQuestion.Notify(game.CurrentQuestion.AnswerTimer);
            Assert.AreEqual(player.GetTile(), tile);
        }
    }
}
