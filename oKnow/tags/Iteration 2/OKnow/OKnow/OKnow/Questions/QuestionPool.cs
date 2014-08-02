using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OKnow.Questions
{
    public class QuestionPool
    {
        private ArrayList movieQuestions;
        private ArrayList tvshowQuestions;
        private ArrayList musicQuestions;
        private ArrayList videogameQuestions;

        public QuestionPool()
        {
            movieQuestions = new ArrayList();
            tvshowQuestions = new ArrayList();
            musicQuestions = new ArrayList();
            videogameQuestions = new ArrayList();
        }

        public void addQuestion(Category category, String qString, String[] choices, Answer answer)
        {
            Question question = new Question(category, qString, choices, answer);

            if (category == Category.MOVIES)
            {
                movieQuestions.Add(question);
            }
            else if (category == Category.TVSHOWS)
            {
                tvshowQuestions.Add(question);
            }
            else if (category == Category.MUSIC)
            {
                musicQuestions.Add(question);
            }
            else if (category == Category.VIDEOGAMES)
            {
                videogameQuestions.Add(question);
            }
        }
    }
}
