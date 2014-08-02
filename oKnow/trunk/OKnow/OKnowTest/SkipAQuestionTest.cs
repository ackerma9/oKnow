using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;
using OKnow;

namespace OKnowTest
{
    [TestClass]
    public class SkipAQuestionTest
    {
		/// <summary>
        /// Tests when a player skips a question
        ///</summary>
        [TestMethod]
        public void SkipQuestionStateTest()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);

            Question question = pool.GetRandQuestion(Category.MOVIES);

            Game1 game = new Game1();
            game.StartGame(2, Category.MOVIES, BoardSize.SMALL, BoardType.STANDARD, null);
            game.GameState = new SkipQuestionState();

            Player player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);
            Assert.AreEqual(player.GetTile(), BoardGenerator.FirstTile);

            player = game.CurrentPlayer;
            game.GameState.TileClick(BoardGenerator.FirstTile);
            Assert.AreEqual(player.GetTile(), BoardGenerator.StartTile);

            game.GameState.QuestionAnswered(true, question);
            Assert.AreEqual(player.GetTile(), BoardGenerator.FirstTile);
        }
    }
}