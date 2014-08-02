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

        [TestInitialize()]
        public void Initialize()
        {
            pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);
            MusicQuestions.addQuestions(pool);
            TVShowQuestions.addQuestions(pool);
            VideoGameQuestions.addQuestions(pool);
        }

        [TestMethod]
        public void TestGetRandomQuestion()
        {
            Question question = pool.getRandQuestion(Category.MOVIES);
            Assert.IsNotNull(question);
            Assert.AreEqual(Category.MOVIES, question.getCategory());
            Assert.AreEqual(QuestionType.STANDARD, question.GetQuestionType());
        }

        [TestMethod]
        public void TestGetRandomMusicQuestion()
        {
            Question question = pool.getRandomMusicQuestion(Category.MOVIES);
            Assert.IsNotNull(question);
            Assert.AreEqual(Category.MOVIES, question.getCategory());
            Assert.AreEqual(QuestionType.MUSIC, question.GetQuestionType());
        }

        [TestMethod]
        public void TestGetRandomImageQuestion()
        {
            Question question = pool.getRandomImageQuestion(Category.MOVIES);
            Assert.IsNotNull(question);
            Assert.AreEqual(Category.MOVIES, question.getCategory());
            Assert.AreEqual(QuestionType.IMAGE, question.GetQuestionType());
        }
    }
}
