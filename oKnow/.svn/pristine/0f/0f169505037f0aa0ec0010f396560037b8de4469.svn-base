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

        [TestInitialize()]
        public void Initialize() {
                q = new Question(Category.NONE, "What Color is the sky?", new string[] { "Green", "Red", "Blue", "Yellow" }, Answer.THREE, QuestionType.STANDARD);
                t = new StandardTile(null, 0, 0);
            }

        [TestMethod()]
        public void testInitialize()
        {
            Assert.IsNotNull(q);
        }

        [TestMethod()]
        public void testAnswerChoices()
        {
            Console.Write(q.getChoices()[0]);
            Assert.IsTrue(q.getChoices().Contains("Green"));
        }

        [TestMethod()]
        public void TestCategory()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);
            MusicQuestions.addQuestions(pool);
            TVShowQuestions.addQuestions(pool);
            VideoGameQuestions.addQuestions(pool);

            Question temp = pool.getRandQuestion(Category.MOVIES);

            Assert.IsNotNull(temp);
            Assert.IsTrue(temp.getCategory() == Category.MOVIES);
        }

        [TestMethod()]
        public void testGetRand()
        {
            QuestionPool pool = new QuestionPool();
            MovieQuestions.addQuestions(pool);
            MusicQuestions.addQuestions(pool);
            TVShowQuestions.addQuestions(pool);
            VideoGameQuestions.addQuestions(pool);

            Question temp = pool.getRandQuestion(Category.MOVIES);

            Assert.IsNotNull(temp);
        }
   }

    
}