using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;
using OKnow;

namespace OKnowTest
{
    [TestClass]
    public class SkipAQuestionTest
    {
        [TestMethod]
        public void SkipQuestionStateTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);

            Question question = pool.getRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.StartGame(2, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD);
            game.GameState = new SkipQuestionState();

            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);
            Assert.AreEqual(player.getTile(), BoardGenerator.FirstTile);

            player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);
            Assert.AreEqual(player.getTile(), BoardGenerator.StartTile);

            game.GameState.QuestionAnswered(true, question);
            Assert.AreEqual(player.getTile(), BoardGenerator.FirstTile);
        }
    }
}