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
    /// Static class to hold references to static fonts
    /// </summary>
    static class StaticFonts
    {
        private static SpriteFont font;
        private static SpriteFont periclesFont;
        private static SpriteFont periclesFont18;
        private static SpriteFont periclesFont42;
        private static SpriteFont periclesFont50;
        private static SpriteFont periclesFont70;

        /// <summary>
        /// Loads all static fonts
        /// </summary>
        /// <param name="content"></param>
        public static void LoadContent(ContentManager content)
        {
            periclesFont = content.Load<SpriteFont>("Fonts/Pericles");
            periclesFont18 = content.Load<SpriteFont>("Fonts/PericlesSize18");
            periclesFont42 = content.Load<SpriteFont>("Fonts/PericlesSize42");
            periclesFont50 = content.Load<SpriteFont>("Fonts/PericlesSize50");
            periclesFont70 = content.Load<SpriteFont>("Fonts/PericlesSize70");
            font = content.Load<SpriteFont>("Fonts/SpriteFont1");
        }
        /// <summary>
        /// Returns a static font
        /// </summary>
        public static SpriteFont Font
        {
            get { return font; }
        }
        /// <summary>
        /// Returns a static font
        /// </summary>
        public static SpriteFont PericlesFont
        {
            get { return periclesFont; }
        }
        /// <summary>
        /// Returns a static font
        /// </summary>
        public static SpriteFont PericlesFont18
        {
            get { return periclesFont18; }
        }
        /// <summary>
        /// Returns a static font
        /// </summary>
        public static SpriteFont PericlesFont42
        {
            get { return periclesFont42; }
        }
        /// <summary>
        /// Returns a static font
        /// </summary>
        public static SpriteFont PericlesFont50
        {
            get { return periclesFont50; }
        }
        /// <summary>
        /// Returns a static font
        /// </summary>
        public static SpriteFont PericlesFont70
        {
            get { return periclesFont70; }
        }
    }
}