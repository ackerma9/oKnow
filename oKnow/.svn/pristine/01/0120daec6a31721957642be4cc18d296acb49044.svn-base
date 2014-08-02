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
    static class StaticTextures
    {
        private static Texture2D pixel;
        public static Texture2D Pixel
        {
            get { return StaticTextures.pixel; }
        }

        private static Texture2D questionBox;
        public static Texture2D QuestionBox
        {
            get { return StaticTextures.questionBox; }
        }

        private static Texture2D answerBox;
        public static Texture2D AnswerBox
        {
            get { return StaticTextures.answerBox; }
        }

        private static Texture2D startImage;
        public static Texture2D StartImage
        {
            get { return StaticTextures.startImage; }
        }

        private static Texture2D startScreenButton;
        public static Texture2D StartScreenButton
        {
            get { return StaticTextures.startScreenButton; }
        }

        private static Texture2D endGameButton;
        public static Texture2D EndGameButton
        {
            get { return StaticTextures.endGameButton; }
        }
        private static Texture2D numPlayerSelecter;
        public static Texture2D NumPlayerSelecter
        {
            get { return StaticTextures.numPlayerSelecter; }
        }

        private static Texture2D answerTile;
        public static Texture2D AnswerTile
        {
            get { return StaticTextures.answerTile; }
        }
        private static Texture2D answerChoice_A_Button;
        public static Texture2D AnswerChoice_A_Button
        {
            get { return StaticTextures.answerChoice_A_Button; }
        }
        private static Texture2D answerChoice_B_Button;
        public static Texture2D AnswerChoice_B_Button
        {
            get { return StaticTextures.answerChoice_B_Button; }
        }
        private static Texture2D answerChoice_C_Button;
        public static Texture2D AnswerChoice_C_Button
        {
            get { return StaticTextures.answerChoice_C_Button; }
        }
        private static Texture2D answerChoice_D_Button;
        public static Texture2D AnswerChoice_D_Button
        {
            get { return StaticTextures.answerChoice_D_Button; }
        }

        private static Texture2D banjoKazooieTile;
        public static Texture2D BanjoKazooieTile
        {
            get { return StaticTextures.banjoKazooieTile; }
        }

        private static Texture2D deathTile;
        public static Texture2D DeathTile
        {
            get { return StaticTextures.deathTile; }
        }

        private static Texture2D endTile;
        public static Texture2D EndTile
        {
            get { return StaticTextures.endTile; }
        }

        private static Texture2D eyeTile;
        public static Texture2D EyeTile
        {
            get { return StaticTextures.eyeTile; }
        }

        private static Texture2D jokerTile;
        public static Texture2D JokerTile
        {
            get { return StaticTextures.jokerTile; }
        }

        private static Texture2D musicTile;
        public static Texture2D MusicTile
        {
            get { return StaticTextures.musicTile; }
        }

        private static Texture2D startTile;
        public static Texture2D StartTile
        {
            get { return StaticTextures.startTile; }
        }

        private static Texture2D timedTile;
        public static Texture2D TimedTile
        {
            get { return StaticTextures.timedTile; }
        }

        private static Texture2D button;
        public static Texture2D Button
        {
            get { return StaticTextures.button; }
        }

        public static void LoadContent(ContentManager content, GraphicsDevice graphicsDevice)
        {
            answerTile = content.Load<Texture2D>("Graphics/StartScreenButton");
            startImage = content.Load<Texture2D>("Graphics/StartImage");
            startScreenButton = content.Load<Texture2D>("Graphics/StartScreenButton");
            endGameButton = content.Load<Texture2D>("Graphics/EndGameButtonImage");
            numPlayerSelecter = content.Load<Texture2D>("Graphics/NumPlayerSelecter");
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

        }
        //TODO: fix this
        public static Texture2D[] categoryButtons;


    }
}