using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;
using OKnow;

namespace OKnowTest
{
    [TestClass]
    public class ChangeCategoryTest
    {

        [TestMethod]
        public void ChangeCategoryStateTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);

            Question question = pool.getRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.StartGame(2, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);

            game.GameState = new ChangeCategoryState();
            Assert.AreEqual(game.GameState.GetType(), typeof(PlayerMoveState));
            Assert.AreNotEqual(game.GameBoard.Category, Category.MOVIES);
        }
    }
}