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
    /// Static class to contain static textures
    /// </summary>
    static class StaticTextures
    {
        private static Boolean contentLoaded = false;
        /// <summary>
        /// Returns true when content is loaded
        /// </summary>
        public static Boolean IsContentLoaded
        {
            get { return contentLoaded; }
        }

        private static Texture2D pixel;
        /// <summary>
        /// Returns a tecture of a single pixel
        /// </summary>
        public static Texture2D Pixel
        {
            get { return StaticTextures.pixel; }
        }

        private static Texture2D questionBox;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D QuestionBox
        {
            get { return StaticTextures.questionBox; }
        }

        private static Texture2D answerBox;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D AnswerBox
        {
            get { return StaticTextures.answerBox; }
        }

        private static Texture2D startImage;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D StartImage
        {
            get { return StaticTextures.startImage; }
        }

        private static Texture2D startScreenButton;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D StartScreenButton
        {
            get { return StaticTextures.startScreenButton; }
        }

        private static Texture2D optionsButton;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D OptionsButton
        {
            get { return StaticTextures.optionsButton; }
        }

        private static Texture2D backButton;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D BackButton
        {
            get { return StaticTextures.backButton; }
        }

        private static Texture2D endGameButton;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D EndGameButton
        {
            get { return StaticTextures.endGameButton; }
        }
        private static Texture2D numPlayerSelecter;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D NumPlayerSelecter
        {
            get { return StaticTextures.numPlayerSelecter; }
        }

        private static Texture2D answerTile;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D AnswerTile
        {
            get { return StaticTextures.answerTile; }
        }
        private static Texture2D answerChoice_A_Button;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D AnswerChoice_A_Button
        {
            get { return StaticTextures.answerChoice_A_Button; }
        }
        private static Texture2D answerChoice_B_Button;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D AnswerChoice_B_Button
        {
            get { return StaticTextures.answerChoice_B_Button; }
        }
        private static Texture2D answerChoice_C_Button;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D AnswerChoice_C_Button
        {
            get { return StaticTextures.answerChoice_C_Button; }
        }
        private static Texture2D answerChoice_D_Button;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D AnswerChoice_D_Button
        {
            get { return StaticTextures.answerChoice_D_Button; }
        }

        private static Texture2D banjoKazooieTile;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D BanjoKazooieTile
        {
            get { return StaticTextures.banjoKazooieTile; }
        }

        private static Texture2D deathTile;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D DeathTile
        {
            get { return StaticTextures.deathTile; }
        }

        private static Texture2D endTile;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D EndTile
        {
            get { return StaticTextures.endTile; }
        }

        private static Texture2D eyeTile;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D EyeTile
        {
            get { return StaticTextures.eyeTile; }
        }

        private static Texture2D jokerTile;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D JokerTile
        {
            get { return StaticTextures.jokerTile; }
        }

        private static Texture2D musicTile;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D MusicTile
        {
            get { return StaticTextures.musicTile; }
        }

        private static Texture2D startTile;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D StartTile
        {
            get { return StaticTextures.startTile; }
        }

        private static Texture2D timedTile;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D TimedTile
        {
            get { return StaticTextures.timedTile; }
        }

        private static Texture2D button;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D Button
        {
            get { return StaticTextures.button; }
        }

        private static Texture2D[] categoryButtons;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D[] CategoryButtons
        {
            get { return StaticTextures.categoryButtons; }
        }

        private static Texture2D[] boardSizeSelector;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D[] BoardSizeSelector
        {
            get { return StaticTextures.boardSizeSelector; }
        }

        private static Texture2D[] boardType;
        /// <summary>
        /// Returns a texture
        /// </summary>
        public static Texture2D[] BoardType
        {
            get { return StaticTextures.boardType; }
        }

        /// <summary>
        /// Loads static content
        /// </summary>
        /// <param name="content">content manager</param>
        /// <param name="graphicsDevice">graphics device</param>
        public static void LoadContent(ContentManager content, GraphicsDevice graphicsDevice)
        {
            answerTile = content.Load<Texture2D>("Graphics/StartScreenButton");
            startImage = content.Load<Texture2D>("Graphics/StartImage");
            startScreenButton = content.Load<Texture2D>("Graphics/StartScreenButton");
            optionsButton = content.Load<Texture2D>("Graphics/OptionsButton");
            backButton = content.Load<Texture2D>("Graphics/BackButton");
            endGameButton = content.Load<Texture2D>("Graphics/EndGameButtonImage");
            numPlayerSelecter = content.Load<Texture2D>("Graphics/DefaultStartScreenButton");
            pixel = new Texture2D(graphicsDevice, 1, 1, false, SurfaceFormat.Color);
            pixel.SetData(new[] { Color.White }); // so that we can draw whatever color we want on top of it
            answerBox = content.Load<Texture2D>("Graphics/AnswerButton");
            answerChoice_A_Button = content.Load<Texture2D>("Graphics/AnswerChoiceAButton");
            answerChoice_B_Button = content.Load<Texture2D>("Graphics/AnswerChoiceBButton");
            answerChoice_C_Button = content.Load<Texture2D>("Graphics/AnswerChoiceCButton");
            answerChoice_D_Button = content.Load<Texture2D>("Graphics/AnswerChoiceDButton");
            questionBox = content.Load<Texture2D>("Graphics/SampleQuestion");

            banjoKazooieTile = content.Load<Texture2D>("Graphics/BanjoKazooieTile");
            deathTile = content.Load<Texture2D>("Graphics/DeathTile");
            endTile = content.Load<Texture2D>("Graphics/EndTile");
            eyeTile = content.Load<Texture2D>("Graphics/eyeTile");
            jokerTile = content.Load<Texture2D>("Graphics/jokerTile");
            musicTile = content.Load<Texture2D>("Graphics/MusicTile");
            startTile = content.Load<Texture2D>("Graphics/StartTile");
            timedTile = content.Load<Texture2D>("Graphics/TimedTile");
            button = content.Load<Texture2D>("Graphics/Button");

            categoryButtons = new Texture2D[] { content.Load<Texture2D>("Graphics/VideoGamesCategoryButton"), content.Load<Texture2D>("Graphics/MoviesCategoryButton"),
                content.Load<Texture2D>("Graphics/MusicCategoryButton"), content.Load<Texture2D>("Graphics/TVShowsCategoryButton")};

            boardSizeSelector = new Texture2D[] { content.Load<Texture2D>("Graphics/smallboardsize"), content.Load<Texture2D>("Graphics/mediumboardsize"),
                content.Load<Texture2D>("Graphics/largeboardsize") };

            boardType = new Texture2D[] { content.Load<Texture2D>("Graphics/standardboardtype"), content.Load<Texture2D>("Graphics/randomboardtype") };
            contentLoaded = true;
        }
    }
}