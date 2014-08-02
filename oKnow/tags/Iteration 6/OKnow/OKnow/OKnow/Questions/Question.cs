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
using Microsoft.Xna.Framework.Input;

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
        private const float ANSWERFEEDBACK = 1.5f;

        private static Random rand = new Random();

        private static Rectangle Answer1Rec = new Rectangle(30, 150, 50, 50);
        private static Rectangle Answer2Rec = new Rectangle(30, 250, 50, 50);
        private static Rectangle Answer3Rec = new Rectangle(30, 350, 50, 50);
        private static Rectangle Answer4Rec = new Rectangle(30, 450, 50, 50);

        private static RectangleLeftClick Answer1 = new RectangleLeftClick(Answer1Rec);
        private static RectangleLeftClick Answer2 = new RectangleLeftClick(Answer2Rec);
        private static RectangleLeftClick Answer3 = new RectangleLeftClick(Answer3Rec);
        private static RectangleLeftClick Answer4 = new RectangleLeftClick(Answer4Rec);

        private static KeyDownEvent answer1Key = new KeyDownEvent(Keys.D1);
        private static KeyDownEvent answer2Key = new KeyDownEvent(Keys.D2);
        private static KeyDownEvent answer3Key = new KeyDownEvent(Keys.D3);
        private static KeyDownEvent answer4Key = new KeyDownEvent(Keys.D4);

        private static TimerEvent answerTimer = null;
        private static TimerEvent timedQuestionTimer = null;

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

        private GameTime currentGameTime = new GameTime();
        private BigText answerFeedbackText = null;
        private Boolean correct = false;

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
        }

        private void RectangleHelper()
        {
            Timer = new Rectangle(Game1.screenWidth/2, Game1.screenHeight/3, 75, 75);

            QuestionForm = new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight);

            imageRectangle = new Rectangle(800, 150, 300, 300);
        }

        private void AddObservers(GameTime gameTime, AbstractTile tile)
        {
            IOSubject.AddObserver(Answer1, this);
            IOSubject.AddObserver(Answer2, this);
            IOSubject.AddObserver(Answer3, this);
            IOSubject.AddObserver(Answer4, this);
            IOSubject.AddObserver(answer1Key, this);
            IOSubject.AddObserver(answer2Key, this);
            IOSubject.AddObserver(answer3Key, this);
            IOSubject.AddObserver(answer4Key, this);

            if (tile.GetType() == typeof(TimedTile))
            {
                timedQuestionTimer = new TimerEvent(gameTime, TIMELIMIT);
                IOSubject.AddObserver(timedQuestionTimer, this);
            }

        }

        public void RemoveObservers()
        {
            timedQuestionTimer = null;
            answerTimer = null;
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
            try
            {
                MediaPlayer.Play(sound);
            }
            catch
            {
            }
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
            currentGameTime = gameTime;
            if (tile.GetType() != typeof(TimedTile))
            {
                return;
            }
        }

        public void Reset(GameTime gameTime, AbstractTile tile)
        {
            RemoveObservers();
            AddObservers(gameTime, tile);
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

        private int questionScore = 50;

        public int getPoints(int attempt)
        {
            if (attempt > 3)
            {
                attempt = 10; 
            }
            return questionScore / attempt;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime, AbstractTile tile)
        {
            spriteBatch.Draw(StaticTextures.QuestionBox, QuestionForm, Color.White);
            int lineNum = 0;
            float stringHeight = (StaticFonts.Font.MeasureString(questionString)).Y;
            int paddingX_Right = 50;
            int paddingX_Left = 25;
            int paddingy = 15;

            if (timedQuestionTimer != null)
            {
                drawTimer(spriteBatch, gameTime);
            }
            

            foreach (string line in WrapText(questionString, Game1.screenWidth-paddingX_Right))
            {
                spriteBatch.DrawString(StaticFonts.Font, line, new Vector2(paddingX_Left, paddingy + lineNum++ * stringHeight), Color.OrangeRed);
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

            if (answerFeedbackText != null)
            {
                answerFeedbackText.Draw(spriteBatch);
            }
        }

        private void drawTimer(SpriteBatch spriteBatch, GameTime gameTime)
        {
            String timeStringValue = ((int)(timedQuestionTimer.SecondsRemaining(gameTime))).ToString();

            float timeHeight = StaticFonts.Font.MeasureString(timeStringValue).Y;
            float timeWidth = StaticFonts.Font.MeasureString(timeStringValue).X;
            float hScale = Timer.Height / timeHeight;
            float wScale = Timer.Width / timeWidth;

            float scale = (hScale < wScale) ? hScale : wScale;

            spriteBatch.DrawString(StaticFonts.Font, timeStringValue, new Vector2(Timer.X, Timer.Y), Color.Black, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
        }

        public void Notify(IOEvent e)
        {
            if (Game1.GameSingleton.IsCurrentQuestion(this))
            {
                
                if (e.Equals(Answer1) ||
                    e.Equals(Answer2) ||
                    e.Equals(Answer4) ||
                    e.Equals(Answer3) ||
                    e.Equals(timedQuestionTimer) ||
                    e.Equals(answer1Key) ||
                    e.Equals(answer2Key) ||
                    e.Equals(answer3Key) ||
                    e.Equals(answer4Key))
                {
                    if (e.Equals(Answer1) || e.Equals(answer1Key))
                    {
                        correct = answer == Answer.ONE;
                    }
                    if (e.Equals(Answer2) || e.Equals(answer2Key))
                    {
                        correct = answer == Answer.TWO;
                    }
                    if (e.Equals(Answer3) || e.Equals(answer3Key))
                    {
                        correct = answer == Answer.THREE;
                    }
                    if (e.Equals(Answer4) || e.Equals(answer4Key))
                    {
                        correct = answer == Answer.FOUR;
                    }
                    if (e.Equals(timedQuestionTimer))
                    {
                        correct = false;
                    }

                    this.RemoveObservers();

                    answerTimer = new TimerEvent(currentGameTime, ANSWERFEEDBACK);
                    IOSubject.AddObserver(answerTimer, this);

                    if (StaticContent.StaticTextures.IsContentLoaded)
                    {
                        String answerFeedbackString = correct ? "Correct!" : "Incorrect!";
                        answerFeedbackText = new BigText(answerFeedbackString, new Vector2(Game1.screenWidth / 2, Game1.screenHeight / 2));
                    }

                    if (StaticSounds.CorrectAnswer != null)
                    {
                        if (correct)
                        {
                            StaticSounds.CorrectAnswer.Play();
                        }
                        else
                        {
                            StaticSounds.IncorrectAnswer.Play();
                        }
                    }
                }

                if(e.Equals(answerTimer))
                {
                    answerFeedbackText = null;
                    Game1.GameSingleton.QuestionAnswered(correct);
                    this.RemoveObservers();
                }
            }
        }

        public TimerEvent AnswerTimer
        {
            get { return answerTimer; }
        }

        public TimerEvent TimedQuestionTimer
        {
            get { return timedQuestionTimer; }
        }

        public RectangleLeftClick CorrectAnswerClickEvent
        {
            get
            {
                if (answer == Answer.ONE)
                {
                    return Answer1;
                }
                if (answer == Answer.TWO)
                {
                    return Answer2;
                }
                if (answer == Answer.THREE)
                {
                    return Answer3;
                }
                if (answer == Answer.FOUR)
                {
                    return Answer4;
                }
                return null;
            }
        }

        public RectangleLeftClick IncorrectAnswerClickEvent
        {
            get
            {
                if (answer != Answer.ONE)
                {
                    return Answer1;
                }
                if (answer != Answer.TWO)
                {
                    return Answer2;
                }
                if (answer != Answer.THREE)
                {
                    return Answer3;
                }
                if (answer != Answer.FOUR)
                {
                    return Answer4;
                }
                return null;
            }
        }

        public KeyDownEvent CorrectAnswerKeyEvent
        {
            get
            {
                if (answer == Answer.ONE)
                {
                    return answer1Key;
                }
                if (answer == Answer.TWO)
                {
                    return answer2Key;
                }
                if (answer == Answer.THREE)
                {
                    return answer3Key;
                }
                if (answer == Answer.FOUR)
                {
                    return answer4Key;
                }
                return null;
            }
        }

        public KeyDownEvent IncorrectAnswerKeyEvent
        {
            get
            {
                if (answer != Answer.ONE)
                {
                    return answer1Key;
                }
                if (answer != Answer.TWO)
                {
                    return answer2Key;
                }
                return null;
            }
        }

    }
}
