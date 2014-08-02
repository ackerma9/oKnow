using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.Questions;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace OKnowTest
{
    [TestClass]
    public class QuestionTest
    {
        Question musicQuestion;
        Question imageQuestion;
        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            musicQuestion = new Question(Category.VIDEOGAMES, "Question?", new String[] { "a", "b", "c", "d" }, Answer.ONE, QuestionType.MUSIC);
            imageQuestion = new Question(Category.VIDEOGAMES, "Question?", new String[] { "a", "b", "c", "d" }, Answer.ONE, QuestionType.IMAGE);
        }
		/// <summary>
        /// Test for checking question types
        ///</summary>
        [TestMethod]
        public void TestQuestionType()
        {
            Assert.AreEqual(QuestionType.MUSIC, musicQuestion.GetQuestionType());
            Assert.AreEqual(QuestionType.IMAGE, imageQuestion.GetQuestionType());
        }
    }
}
