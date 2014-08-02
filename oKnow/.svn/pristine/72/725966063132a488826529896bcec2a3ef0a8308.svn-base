using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;
using OKnow;

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
            game.StartGame(1, Category.MOVIES);
            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);
            game.GameState.QuestionAnswered(true, question);
            Assert.AreEqual(player.getTile(), BoardGenerator.FirstTile);

        }
    }
}
