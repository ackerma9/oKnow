using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.Resources;
using OKnow.UI;
namespace OKnow.Questions
{
    public class Question : IOObserver
    {
        
        private static Random rand = new Random();
        private Category category;
        private String questionString;
        private String[] choices;
        private Answer answer;
        public bool correct = false;
        private RightClickEvent rightClick;
        private Rectangle QuestionForm;
        private Rectangle Answer1Rec;
        private Rectangle Answer2Rec;
        private Rectangle Answer3Rec;
        private Rectangle Answer4Rec;
        private RectangleLeftClick Answer1;
        private RectangleLeftClick Answer2;
        private RectangleLeftClick Answer3;
        private RectangleLeftClick Answer4;

        public Question(Category category, String qString, String[] choices, Answer answer)
        {
            this.category = category;
            this.questionString = qString;
            this.choices = choices;
            this.answer = answer;
            ShuffleChoices();

            RectangleHelper();
            rightClick = new RightClickEvent();
            AddObservers();
        }

        private void RectangleHelper()
        {
            Answer1Rec = new Rectangle(30, 150, 50, 50);
            Answer2Rec = new Rectangle(30, 250, 50, 50);
            Answer3Rec = new Rectangle(30, 350, 50, 50);
            Answer4Rec = new Rectangle(30, 450, 50, 50);
            QuestionForm = new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight);

            Answer1 = new RectangleLeftClick(Answer1Rec);
            Answer2 = new RectangleLeftClick(Answer2Rec);
            Answer3 = new RectangleLeftClick(Answer3Rec);
            Answer4 = new RectangleLeftClick(Answer4Rec);
        }

        private void AddObservers()
        {
            IOSubject.AddObserver(rightClick, this);
            IOSubject.AddObserver(Answer1, this);
            IOSubject.AddObserver(Answer2, this);
            IOSubject.AddObserver(Answer3, this);
            IOSubject.AddObserver(Answer4, this);
        }

        public Category getCategory()
        {
            return category;
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
            float spaceWidth = Game1.font.MeasureString(Strings.singleSpace).X;
            int CurLine = 0;
            Lines.Add(string.Empty);

            foreach (string word in words)
            {
                Vector2 size = Game1.font.MeasureString(word);
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

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Game1.QuestionBox, QuestionForm, Color.White);
            int lineNum = 0;
            float stringHeight = Game1.font.MeasureString(questionString).Y;
            float stringWidth = Game1.font.MeasureString(questionString).X;
            int paddingx = 25;
            int paddingy = 15;

            foreach (string line in WrapText(questionString, Game1.screenWidth-paddingx)){
                spriteBatch.DrawString(Game1.font, line, new Vector2(paddingx, paddingy + lineNum * stringHeight), Color.OrangeRed);
                lineNum++;
            }

            spriteBatch.Draw(Game1.AnswerButton, Answer1Rec, Color.White);
            spriteBatch.Draw(Game1.AnswerButton, Answer2Rec, Color.White);
            spriteBatch.Draw(Game1.AnswerButton, Answer3Rec, Color.White);
            spriteBatch.Draw(Game1.AnswerButton, Answer4Rec, Color.White);

            spriteBatch.DrawString(Game1.font, choices[0], new Vector2(85, 160), Color.Black);
            spriteBatch.DrawString(Game1.font, choices[1], new Vector2(85, 260), Color.Black);
            spriteBatch.DrawString(Game1.font, choices[2], new Vector2(85, 360), Color.Black);
            spriteBatch.DrawString(Game1.font, choices[3], new Vector2(85, 460), Color.Black);
        }

        public void Notify(IOEvent e)
        {
            if (e == rightClick)
            {
                Game1.getSingleton().Question = null;
            }

            if (e == Answer1)
            {
                if ((int)answer == 1)
                    correct = true;

                Game1.getSingleton().Question = null;
            }
            if (e == Answer2)
            {
                if ((int)answer == 2)
                    correct = true;

                Game1.getSingleton().Question = null;
            }
            if (e == Answer3)
            {
                if ((int)answer == 3)
                    correct = true;

                Game1.getSingleton().Question = null;
            }
            if (e == Answer4)
            {
                if ((int)answer == 4)
                    correct = true;

                Game1.getSingleton().Question = null;
            }
        }
    }
}
