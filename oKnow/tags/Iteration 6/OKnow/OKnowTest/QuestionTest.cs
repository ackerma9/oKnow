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

        [TestInitialize()]
        public void Initialize()
        {
            musicQuestion = new Question(Category.VIDEOGAMES, "Question?", new String[] { "a", "b", "c", "d" }, Answer.ONE, QuestionType.MUSIC);
            imageQuestion = new Question(Category.VIDEOGAMES, "Question?", new String[] { "a", "b", "c", "d" }, Answer.ONE, QuestionType.IMAGE);
        }

        [TestMethod]
        public void TestQuestionType()
        {
            Assert.AreEqual(QuestionType.MUSIC, musicQuestion.GetQuestionType());
            Assert.AreEqual(QuestionType.IMAGE, imageQuestion.GetQuestionType());
        }
    }
}
