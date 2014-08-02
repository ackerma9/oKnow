using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.Resources;
using OKnow.UI;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using OKnow.StaticContent;
using OKnow.Pieces;

namespace OKnow.Questions
{
    public enum QuestionType
    {
        NONE = 0,
        STANDARD = 1,
        MUSIC = 2,
        IMAGE = 3
    }

    public class Question : IOObserver
    {
        private const float TIMELIMIT = 10f;
        private float secondsRemaining;
        private static Random rand = new Random();

        private static Rectangle Answer1Rec = new Rectangle(30, 150, 50, 50);
        private static Rectangle Answer2Rec = new Rectangle(30, 250, 50, 50);
        private static Rectangle Answer3Rec = new Rectangle(30, 350, 50, 50);
        private static Rectangle Answer4Rec = new Rectangle(30, 450, 50, 50);

        private static RectangleLeftClick Answer1 = new RectangleLeftClick(Answer1Rec);
        private static RectangleLeftClick Answer2 = new RectangleLeftClick(Answer2Rec);
        private static RectangleLeftClick Answer3 = new RectangleLeftClick(Answer3Rec);
        private static RectangleLeftClick Answer4 = new RectangleLeftClick(Answer4Rec);

        private Category category;
        private String questionString;
        private String[] choices;
        private Answer answer;
        private QuestionType type;

        private Song sound;
        private Texture2D image;

        private Rectangle QuestionForm;


        private Rectangle Timer;


        private Rectangle imageRectangle;

        public Question(Category category, String qString, String[] choices, Answer answer, QuestionType type)
        {
            this.category = category;
            this.questionString = qString;
            this.choices = choices;
            this.answer = answer;
            this.type = type;
            sound = null;
            image = null;
            ShuffleChoices();

            RectangleHelper();

            secondsRemaining = TIMELIMIT;
        }

        private void RectangleHelper()
        {
            Timer = new Rectangle(Game1.screenWidth/2, Game1.screenHeight/3, 75, 75);

            QuestionForm = new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight);

            imageRectangle = new Rectangle(800, 150, 300, 300);
        }

        private void AddObservers()
        {
            IOSubject.AddObserver(Answer1, this);
            IOSubject.AddObserver(Answer2, this);
            IOSubject.AddObserver(Answer3, this);
            IOSubject.AddObserver(Answer4, this);
        }

        public void RemoveObservers()
        {
            IOSubject.RemoveObserver(this);
        }

        public Song Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        public Texture2D Image
        {
            get { return image; }
            set { image = value; }
        }

        public void PlaySound()
        {
            MediaPlayer.Play(sound);
        }

        public QuestionType GetQuestionType()
        {
            return type;
        }

        public Category getCategory()
        {
            return category;
        }

        public void Update(GameTime gameTime, AbstractTile tile)
        {
            if (tile.GetType() != typeof(TimedTile))
            {
                return;
            }
            secondsRemaining = secondsRemaining - (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (secondsRemaining <= 0)
            {
                Game1.GameSingleton.QuestionAnswered(false);
                Game1.GameSingleton.CurrentPlayer.attempt += 1;
            }
        }

        public void Reset()
        {
            secondsRemaining = TIMELIMIT;
            AddObservers();
        }

        private void ShuffleChoices()
        {
            String answerChoice = this.getAnswer();

            int[] map = new int[choices.Length];
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = i;
            }

            Array.Sort(map, (i1, i2) => (rand.Next() % 2 == 0) ? -1 : 1);

            String[] newChoices = new String[choices.Length];
            answer = (Answer)map[(int)answer];

            for (int i = 0; i < map.Length; i++)
            {
                newChoices[map[i]] = choices[i];
            }
            choices = newChoices;

            if (answerChoice.CompareTo(this.getAnswer()) != 0)
            {
                throw new Exception("ShuffleChoices has failed");
            }
        }

        public String getQuestionString()
        {
            return questionString;
        }

        public String[] getChoices()
        {
            return choices;
        }

        public String getAnswer()
        {
            return choices[(int)answer];
        }

        public Answer getObjectAnswer()
        {
            return answer;
        }

        private object[] WrapText(string text, float Length)
        {
            string[] words = text.Split(' ');
            List<string> Lines = new List<string>();
            float linewidth = 0f;
            float spaceWidth = StaticFonts.Font.MeasureString(Strings.singleSpace).X;
            int CurLine = 0;
            Lines.Add(string.Empty);

            foreach (string word in words)
            {
                Vector2 size = StaticFonts.Font.MeasureString(word);
                if (linewidth + size.X < Length)
                {
                    Lines[CurLine] += word + " ";
                    linewidth += size.X + spaceWidth;
                }
                else
                {
                    Lines.Add(word + " ");
                    linewidth = size.X + spaceWidth;
                    CurLine++;
                }
            }

            return Lines.ToArray();
        }

        public int getPoints(int attempt)
        {
            if (attempt == 1)
                return 50;
            else if (attempt == 2)
                return 25;
            else if (attempt == 3)
                return 10;
            else
                return 5;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime, AbstractTile tile)
        {
            spriteBatch.Draw(StaticTextures.QuestionBox, QuestionForm, Color.White);
            int lineNum = 0;
            float stringHeight = StaticFonts.Font.MeasureString(questionString).Y;
            float stringWidth = StaticFonts.Font.MeasureString(questionString).X;
            int paddingX_Right = 50;
            int paddingX_Left = 25;
            int paddingy = 15;

            if (tile.GetType() == typeof(TimedTile))
            {
                drawTimer(spriteBatch, gameTime);
            }
            

            foreach (string line in WrapText(questionString, Game1.screenWidth-paddingX_Right)){
                spriteBatch.DrawString(StaticFonts.Font, line, new Vector2(paddingX_Left, paddingy + lineNum * stringHeight), Color.OrangeRed);
                lineNum++;
            }

            spriteBatch.Draw(StaticTextures.AnswerChoice_A_Button, Answer1Rec, Color.White);
            spriteBatch.Draw(StaticTextures.AnswerChoice_B_Button, Answer2Rec, Color.White);
            spriteBatch.Draw(StaticTextures.AnswerChoice_C_Button, Answer3Rec, Color.White);
            spriteBatch.Draw(StaticTextures.AnswerChoice_D_Button, Answer4Rec, Color.White);

            spriteBatch.DrawString(StaticFonts.Font, choices[0], new Vector2(85, 160), Color.Black);
            spriteBatch.DrawString(StaticFonts.Font, choices[1], new Vector2(85, 260), Color.Black);
            spriteBatch.DrawString(StaticFonts.Font, choices[2], new Vector2(85, 360), Color.Black);
            spriteBatch.DrawString(StaticFonts.Font, choices[3], new Vector2(85, 460), Color.Black);

            if (type == QuestionType.IMAGE)
            {
                spriteBatch.Draw(image, imageRectangle, Color.White);
            }
        }

        private void drawTimer(SpriteBatch spriteBatch, GameTime gameTime)
        {
            String timeStringValue = ((int)(secondsRemaining)).ToString();

            float timeHeight = StaticFonts.Font.MeasureString(timeStringValue).Y;
            float timeWidth = StaticFonts.Font.MeasureString(timeStringValue).X;
            float hScale = Timer.Height / timeHeight;
            float wScale = Timer.Height / timeHeight;

            float scale = (hScale < wScale) ? hScale : wScale;

            spriteBatch.DrawString(StaticFonts.Font, timeStringValue, new Vector2(Timer.X, Timer.Y), Color.Black, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
        }

        public void Notify(IOEvent e)
        {
            if (Game1.GameSingleton.IsCurrentQuestion(this))
            {
                Boolean correct = false;
                if (e.Equals(Answer1))
                {
                    correct = answer == Answer.ONE;
                }
                if (e.Equals(Answer2))
                {
                    correct = answer == Answer.TWO;
                }
                if (e.Equals(Answer3))
                {
                    correct = answer == Answer.THREE;
                }
                if (e.Equals(Answer4))
                {
                    correct = answer == Answer.FOUR;
                }


                Game1.GameSingleton.QuestionAnswered(correct);
            }
        }
    }
}
