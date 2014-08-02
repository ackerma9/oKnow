using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;
using OKnow;

namespace OKnowTest
{
    [TestClass]
    public class ChangeCategoryTest
    {
		/// <summary>
        /// Test for changing the category of a game
        ///</summary>
        [TestMethod]
        public void ChangeCategoryStateTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);

            Question question = pool.GetRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.StartGame(2, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);

            game.GameState = new ChangeCategoryState();
            Assert.AreEqual(game.GameState.GetType(), typeof(PlayerMoveState));
            Assert.AreNotEqual(game.GameBoard.Category, Category.MOVIES);
        }
    }
}