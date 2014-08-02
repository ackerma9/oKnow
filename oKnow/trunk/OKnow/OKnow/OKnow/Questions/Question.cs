using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.UI;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using OKnow.StaticContent;
using OKnow.Pieces;
using Microsoft.Xna.Framework.Input;

namespace OKnow.Questions
{
    /// <summary>
    /// Question type enumeration that determines the type of question
    /// </summary>
    public enum QuestionType
    {
        NONE = 0,
        STANDARD = 1,
        MUSIC = 2,
        IMAGE = 3
    }

    /// <summary>
    /// Question class that handles generating observers drawing the appropriate question
    /// Extends IOObserver due to its interactive nature
    /// </summary>
    public class Question : IOObserver
    {
        /// <summary>
        /// Timer fields, limit for answering a question
        /// </summary>
        private const float TIMELIMIT = 10f;
        private const float ANSWERFEEDBACK = 1.5f;

        /// <summary>
        /// A random seeder for shuffling questions
        /// </summary>
        private static Random rand = new Random();

        /// <summary>
        /// Static rectangles representing choices for the player to select
        /// </summary>
        private static Rectangle Answer1Rec = new Rectangle(30, 150, 50, 50);
        private static Rectangle Answer2Rec = new Rectangle(30, 250, 50, 50);
        private static Rectangle Answer3Rec = new Rectangle(30, 350, 50, 50);
        private static Rectangle Answer4Rec = new Rectangle(30, 450, 50, 50);

        /// <summary>
        /// LeftClick observers that activate the gamestate class
        /// </summary>
        private static RectangleLeftClick Answer1 = new RectangleLeftClick(Answer1Rec);
        private static RectangleLeftClick Answer2 = new RectangleLeftClick(Answer2Rec);
        private static RectangleLeftClick Answer3 = new RectangleLeftClick(Answer3Rec);
        private static RectangleLeftClick Answer4 = new RectangleLeftClick(Answer4Rec);

        /// <summary>
        /// KeyDownEvents that allow the player to answer questions via the keyboard
        /// Extends the IOEvent class
        /// </summary>
        private static KeyDownEvent answer1Key = new KeyDownEvent(Keys.D1);
        private static KeyDownEvent answer2Key = new KeyDownEvent(Keys.D2);
        private static KeyDownEvent answer3Key = new KeyDownEvent(Keys.D3);
        private static KeyDownEvent answer4Key = new KeyDownEvent(Keys.D4);

        /// <summary>
        /// Timer events for timed tiles as well as standard tiles
        /// </summary>
        private static TimerEvent answerTimer = null;
        private static TimerEvent timedQuestionTimer = null;

        public static readonly String singleSpace = " ";

        /// <summary>
        /// All fields necessary for a question (i.e. category, answers, type, ...)
        /// </summary>
        private Category category;
        private String questionString;
        private String[] choices;
        private Answer answer;
        private QuestionType type;

        /// <summary>
        /// Fields for sound and image tiles (loaded from StaticContent)
        /// </summary>
        private Song sound;
        private Texture2D image;

        /// <summary>
        /// Rectangles to house the question, image, and timer
        /// </summary>
        private Rectangle QuestionForm;
        private Rectangle Timer;
        private Rectangle imageRectangle;

        /// <summary>
        /// Current game time field that is used for timer
        /// </summary>
        private GameTime currentGameTime = new GameTime();

        /// <summary>
        /// Feedback that displays correct/incorrect depending on user response to 
        /// question
        /// </summary>
        private BigText answerFeedbackText = null;

        /// <summary>
        /// Boolean value to store whether user's response answered the question
        /// correctly
        /// </summary>
        private Boolean correct = false;


        /// <summary>
        /// Question constructor that does a few things
        /// 1) Stores the question in proper format
        /// 2) Shuffles the choices so user does not get too familiar w/question
        /// 3)Generates the IOObservers (i.e. answer rectangles, timer, ...)
        /// </summary>
        /// <param name="category"></param>
        /// <param name="qString"></param>
        /// <param name="choices"></param>
        /// <param name="answer"></param>
        /// <param name="type"></param>
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

        /// <summary>
        /// Rectangle helper function called by constructor
        /// Generates the question form, the timer, and an image rectangle (the last two if necessary)
        /// </summary>
        private void RectangleHelper()
        {
            Timer = new Rectangle(Game1.screenWidth/2, Game1.screenHeight/3, 75, 75);

            QuestionForm = new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight);

            imageRectangle = new Rectangle(800, 150, 300, 300);
        }

        /// <summary>
        /// AddObservers helper function that adds observers to IODictionary
        /// Grabs game time and sets up timer object if current tile is a timed tile
        /// </summary>
        /// <param name="gameTime"></param>
        /// <param name="tile"></param>
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

        /// <summary>
        /// Extended IOSubject RemoveObservers function that calls its parent functions
        /// <seealso cref="IOSubject.cs"/>
        /// </summary>
        public void RemoveObservers()
        {
            timedQuestionTimer = null;
            answerTimer = null;
            IOSubject.RemoveObserver(this);
        }

        /// <summary>
        /// Getter for the sound static content
        /// associated with current question
        /// </summary>
        public Song Sound
        {
            get { return sound; }
            set { sound = value; }
        }

        /// <summary>
        /// Getter for image static content associated
        /// with current question
        /// </summary>
        public Texture2D Image
        {
            get { return image; }
            set { image = value; }
        }

        /// <summary>
        /// Method to play sound (buzz for incorrect, ding for correct)
        /// </summary>
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

        /// <summary>
        /// Getter for the current question type, based on
        /// the enumerator above
        /// </summary>
        /// <returns></returns>
        public QuestionType GetQuestionType()
        {
            return type;
        }

        /// <summary>
        /// Gets the current question objects category
        /// <seealso cref="Category.cs"/>
        /// </summary>
        /// <returns></returns>
        public Category GetCategory()
        {
            return category;
        }

        /// <summary>
        /// Function to update the current game time
        /// </summary>
        /// <param name="gameTime"></param>
        /// <param name="tile"></param>
        public void Update(GameTime gameTime, AbstractTile tile)
        {
            currentGameTime = gameTime;
            if (tile.GetType() != typeof(TimedTile))
            {
                return;
            }
        }

        /// <summary>
        /// Reset function to remove observers
        /// </summary>
        /// <param name="gameTime"></param>
        /// <param name="tile"></param>
        public void Reset(GameTime gameTime, AbstractTile tile)
        {
            RemoveObservers();
            AddObservers(gameTime, tile);
        }

        /// <summary>
        /// Function to shuffle the question's choices
        /// in order to confuse player
        /// </summary>
        private void ShuffleChoices()
        {
            String answerChoice = this.GetAnswer();

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

            if (answerChoice.CompareTo(this.GetAnswer()) != 0)
            {
                throw new Exception("ShuffleChoices has failed");
            }
        }

        /// <summary>
        /// Getter for the current question string
        /// </summary>
        /// <returns></returns>
        public String GetQuestionString()
        {
            return questionString;
        }

        /// <summary>
        /// Getter for the current question's answer choices
        /// </summary>
        /// <returns></returns>
        public String[] GetChoices()
        {
            return choices;
        }

        /// <summary>
        /// Getter for the current question's correct answer
        /// </summary>
        /// <returns></returns>
        public String GetAnswer()
        {
            return choices[(int)answer];
        }

        /// <summary>
        /// Gets the answer enum type
        /// <seealso cref="Answer.cs"/>
        /// </summary>
        /// <returns></returns>
        public Answer GetObjectAnswer()
        {
            return answer;
        }

        /// <summary>
        /// Wrap text method in case of long questions, the string must fit to
        /// the dimensions of the question form.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        private object[] WrapText(string text, float Length)
        {
            string[] words = text.Split(' ');
            List<string> Lines = new List<string>();
            float linewidth = 0f;
            float spaceWidth = StaticFonts.Font.MeasureString(singleSpace).X;
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

        /// <summary>
        /// questionscore field that is changed by attempt number
        /// </summary>
        private int questionScore = 50;

        /// <summary>
        /// Function to get the points based off the attempts for the player
        /// </summary>
        /// <param name="attempt"></param>
        /// <returns></returns>
        public int GetPoints(int attempt)
        {
            if (attempt > 3)
            {
                attempt = 10; 
            }
            return questionScore / attempt;
        }

        /// <summary>
        /// The Draw function for the question
        /// Draws all observers necessary based on question type
        /// </summary>
        /// <param name="spriteBatch"></param>
        /// <param name="gameTime"></param>
        /// <param name="tile"></param>
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
                DrawTimer(spriteBatch, gameTime);
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

        /// <summary>
        /// Helper function to draw the timer in the case of a timed tile
        /// </summary>
        /// <param name="spriteBatch"></param>
        /// <param name="gameTime"></param>
        private void DrawTimer(SpriteBatch spriteBatch, GameTime gameTime)
        {
            String timeStringValue = ((int)(timedQuestionTimer.SecondsRemaining(gameTime))).ToString();

            float timeHeight = StaticFonts.Font.MeasureString(timeStringValue).Y;
            float timeWidth = StaticFonts.Font.MeasureString(timeStringValue).X;
            float hScale = Timer.Height / timeHeight;
            float wScale = Timer.Width / timeWidth;

            float scale = (hScale < wScale) ? hScale : wScale;

            spriteBatch.DrawString(StaticFonts.Font, timeStringValue, new Vector2(Timer.X, Timer.Y), Color.Black, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
        }

        /// <summary>
        /// Overidden Notify function that handles IOEvents (i.e. player responses)
        /// Determines if answer is correct and response accordingly (updating attempts, displaying big text)
        /// </summary>
        /// <param name="e"></param>
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

        /// <summary>
        /// Getter for the AnswerTimer IOSubject
        /// </summary>
        public TimerEvent AnswerTimer
        {
            get { return answerTimer; }
        }

        /// <summary>
        /// Gets the timedQuestion timer in case of timed tiles
        /// </summary>
        public TimerEvent TimedQuestionTimer
        {
            get { return timedQuestionTimer; }
        }

        /// <summary>
        /// Strictly for testing, method to register a correct answer event
        /// </summary>
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

        /// <summary>
        /// Rectangle left click event that is meant to register an incorrect
        /// answer event, strictly for testing
        /// </summary>
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


        /// <summary>
        /// Method strictly for testing, allows for correct key down events
        /// </summary>
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

        /// <summary>
        /// Method strictly for testing, allows for incorrect key down events
        /// </summary>
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
