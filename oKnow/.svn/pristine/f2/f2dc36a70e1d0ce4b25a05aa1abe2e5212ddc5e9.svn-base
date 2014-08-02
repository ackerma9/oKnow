using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;
using OKnow.Questions;
using OKnow.Pieces;

namespace OKnowTest{

    [TestClass]

    public class AnswerTest{

        private Question q;
        private AbstractTile t;

		/// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize() {
                q = new Question(Category.NONE, "What Color is the sky?", new string[] { "Green", "Red", "Blue", "Yellow" }, Answer.THREE, QuestionType.STANDARD);
                t = new StandardTile(null, 0, 0);
            }
		/// <summary>
        /// Test for intializing questions
        ///</summary>
        [TestMethod()]
        public void TestInitialize()
        {
            Assert.IsNotNull(q);
        }
		/// <summary>
        /// Test for checking answer choices
        ///</summary>
        [TestMethod()]
        public void TestAnswerChoices()
        {
            Console.Write(q.GetChoices()[0]);
            Assert.IsTrue(q.GetChoices().Contains("Green"));
        }
		/// <summary>
        /// Test for checking for the correct category
        ///</summary>
        [TestMethod()]
        public void TestCategory()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);
            MusicQuestions.AddQuestions(pool);
            TVShowQuestions.AddQuestions(pool);
            VideoGameQuestions.AddQuestions(pool);

            Question temp = pool.GetRandQuestion(Category.MOVIES);

            Assert.IsNotNull(temp);
            Assert.IsTrue(temp.GetCategory() == Category.MOVIES);
        }
		/// <summary>
        /// Test for generating random questions
        ///</summary>
        [TestMethod()]
        public void TestGetRand()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.AddQuestions(pool);
            MusicQuestions.AddQuestions(pool);
            TVShowQuestions.AddQuestions(pool);
            VideoGameQuestions.AddQuestions(pool);

            Question temp = pool.GetRandQuestion(Category.MOVIES);

            Assert.IsNotNull(temp);
        }
   }
}