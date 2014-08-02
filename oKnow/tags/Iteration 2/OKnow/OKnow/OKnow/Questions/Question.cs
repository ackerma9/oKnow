using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.Resources;

namespace OKnow.Questions
{
    public class Question
    {
        private static Random rand = new Random();
        private Category category;
        private String questionString;
        private String[] choices;
        private Answer answer;

        public Question(Category category, String qString, String[] choices, Answer answer)
        {
            this.category = category;
            this.questionString = qString;
            this.choices = choices;
            this.answer = answer;
            ShuffleChoices();
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
            Texture2D FillText = Game1.getSingleton().getPixel();
            Rectangle MainBox;
            MainBox.Width = 400;
            MainBox.Height = 700;
            MainBox.X = 1280 / 2 - MainBox.Width / 2;
            MainBox.Y = 640 / 2 - MainBox.Height / 2;

            Rectangle TitleBox;
            TitleBox.Width = 350;
            SpriteFont newFont = Game1.font;
            TitleBox.Height = (int)newFont.MeasureString(questionString).Y;
            int Padding = MainBox.Width / 2 - TitleBox.Width / 2;
            TitleBox.X = Padding + MainBox.X;
            TitleBox.Y = Padding + MainBox.Y;

            Rectangle TextSeparator;
            TextSeparator.Width = MainBox.Width - Padding * 2;
            TextSeparator.Height = 1;
            TextSeparator.X = MainBox.X + Padding;
            TextSeparator.Y = TitleBox.Y + (int)(Padding * 1.2);

            Rectangle PictureBox;
            PictureBox.Width = 0;
            PictureBox.Height = 250;
            PictureBox.X = MainBox.X + Padding;
            PictureBox.Y = MainBox.Y + TitleBox.Height + Padding * 2;

            MainBox.Height = PictureBox.Y - MainBox.Y + PictureBox.Height + Padding;

            Rectangle TextBody;
            TextBody.Width = MainBox.Width - (Padding * 2);
            TextBody.Height = MainBox.Height - (Padding * 3) - TitleBox.Height;
            TextBody.X = PictureBox.X;
            TextBody.Y = TitleBox.Y + TitleBox.Height + Padding;

            spriteBatch.Draw(FillText, MainBox, Color.Wheat);
            spriteBatch.DrawString(newFont, questionString, new Vector2(TitleBox.X, TitleBox.Y), Color.Blue);

            int LineNumber = 0;
            string newAnswers = "";
            foreach (string curr in choices)
                newAnswers += curr + "\n";

            foreach (string Line in WrapText(newAnswers, TextBody.Width))
            {
                spriteBatch.DrawString(newFont, Line, new Vector2(TextBody.X, TextBody.Y + (LineNumber * newFont.MeasureString(Line).Y)), Color.Black);
            }
        }
    }
}
