using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;
using OKnow;

namespace OKnowTest
{
    [TestClass]
    public class ResetAttemptsTest
    {
		/// <summary>
        /// Tests the reset function for attempts
        ///</summary>
        [TestMethod]
        public void ResetAttemptsStateTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);

            Question question = pool.GetRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.StartGame(2, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            game.CurrentPlayer.attempt = 3;

            game.GameState = new ResetAttemptsState();
            Assert.AreEqual(game.GameState.GetType(), typeof(PlayerMoveState));
            Assert.AreEqual(game.CurrentPlayer.attempt, 1);
        }
    }
}
