using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace OKnow.StaticContent
{
    static class StaticSounds
    {
        private static SoundEffect correctAnswer;
        private static SoundEffect incorrectAnswer;

        private static Boolean contentLoaded = false;

        public static void LoadContent(ContentManager content)
        {
            try
            {
                correctAnswer = content.Load<SoundEffect>("Sounds/CorrectAnswer");
                incorrectAnswer = content.Load<SoundEffect>("Sounds/WrongAnswer");
                contentLoaded = true;
            }
            catch
            {
                Boolean i = contentLoaded;
            }
        }

        public static SoundEffect CorrectAnswer
        {
            get { return correctAnswer; }
        }

        public static SoundEffect IncorrectAnswer
        {
            get { return incorrectAnswer; }
        }
    }
}
