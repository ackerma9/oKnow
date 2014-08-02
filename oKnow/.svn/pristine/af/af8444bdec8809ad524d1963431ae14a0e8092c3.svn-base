using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;

namespace OKnowTest
{
    [TestClass]
    public class QuestionPoolTest
    {
        QuestionPool pool;

		/// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);
            MusicQuestions.AddQuestions(pool);
            TVShowQuestions.AddQuestions(pool);
            VideoGameQuestions.AddQuestions(pool);
        }
		/// <summary>
        /// Test for getting a random question
        ///</summary>
        [TestMethod]
        public void TestGetRandomQuestion()
        {
            Question question = pool.GetRandQuestion(Category.MOVIES);
            Assert.IsNotNull(question);
            Assert.AreEqual(Category.MOVIES, question.GetCategory());
            Assert.AreEqual(QuestionType.STANDARD, question.GetQuestionType());
        }
		/// <summary>
        /// Test for getting a random sound question
        ///</summary>
        [TestMethod]
        public void TestGetRandomMusicQuestion()
        {
            Question question = pool.GetRandomMusicQuestion(Category.MOVIES);
            Assert.IsNotNull(question);
            Assert.AreEqual(Category.MOVIES, question.GetCategory());
            Assert.AreEqual(QuestionType.MUSIC, question.GetQuestionType());
        }
		/// <summary>
        /// Test for getting a random image question
        ///</summary>
        [TestMethod]
        public void TestGetRandomImageQuestion()
        {
            Question question = pool.GetRandomImageQuestion(Category.MOVIES);
            Assert.IsNotNull(question);
            Assert.AreEqual(Category.MOVIES, question.GetCategory());
            Assert.AreEqual(QuestionType.IMAGE, question.GetQuestionType());
        }
    }
}
