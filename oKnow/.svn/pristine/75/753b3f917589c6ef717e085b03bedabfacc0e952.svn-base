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

        public static void LoadContent(ContentManager content)
        {
            correctAnswer = content.Load<SoundEffect>("Sounds/CorrectAnswer");
            incorrectAnswer = content.Load<SoundEffect>("Sounds/WrongAnswer");
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
