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
    /// <summary>
    /// Static class to reference static sounds
    /// </summary>
    static class StaticSounds
    {
        private static SoundEffect correctAnswer;
        private static SoundEffect incorrectAnswer;
        private static Song bkTheme;
        private static Song srTheme;

        private static Boolean contentLoaded = false;

        /// <summary>
        /// Loads content
        /// </summary>
        /// <param name="content">content manager</param>
        public static void LoadContent(ContentManager content)
        {
            try
            {
                correctAnswer = content.Load<SoundEffect>("Sounds/CorrectAnswer");
                incorrectAnswer = content.Load<SoundEffect>("Sounds/WrongAnswer");
                bkTheme = content.Load<Song>("Sounds/bkTheme");
                srTheme = content.Load<Song>("Sounds/srTheme");

                contentLoaded = true;
            }
            catch
            {
                Boolean i = contentLoaded;
            }
        }


        /// <summary>
        /// Returns a sound
        /// </summary>
        public static SoundEffect CorrectAnswer
        {
            get { return correctAnswer; }
        }

        /// <summary>
        /// Returns a sound
        /// </summary>
        public static SoundEffect IncorrectAnswer
        {
            get { return incorrectAnswer; }
        }

        /// <summary>
        /// Returns a sound
        /// </summary>
        public static Song BkTheme
        {
            get { return bkTheme; }
        }

        /// <summary>
        /// Returns a sound
        /// </summary>
        public static Song SrTheme
        {
            get { return srTheme; }
        }
    }
}
