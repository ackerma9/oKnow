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
        Random rand;

        public QuestionPool()
        {
            movieQuestions = new ArrayList();
            tvshowQuestions = new ArrayList();
            musicQuestions = new ArrayList();
            videogameQuestions = new ArrayList();
            rand = new Random();
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

        public Question getRandQuestion(Category category)
        {
            Console.WriteLine("Inside getRandQuestion");

                switch(category){

                    case Category.MOVIES:
                        int movieLength = movieQuestions.Count;
                        Console.WriteLine("movieArray length: " + movieLength);
                        int movieIndex = rand.Next(1,movieLength-1);
                        Console.WriteLine("movieIndex: " + movieIndex);
                        return (Question)movieQuestions[movieIndex];

                    case Category.MUSIC:
                        int musicLength = musicQuestions.Count;
                        Console.WriteLine("musicArray length: " + musicLength);
                        int musicIndex = rand.Next(1, musicLength-1);
                        Console.WriteLine("musicIndex: " + musicIndex);
                        return (Question)movieQuestions[musicIndex];

                    case Category.TVSHOWS:
                        int tvLength = musicQuestions.Count;
                        Console.WriteLine("tvArray length: " + tvLength);
                        int tvIndex = rand.Next(1, tvLength-1);
                        Console.WriteLine("tvIndex: " + tvIndex);
                        return (Question)tvshowQuestions[tvIndex];

                    case Category.VIDEOGAMES:
                        int videoLength = videogameQuestions.Count;
                        Console.WriteLine("videogameArray length: " + videoLength);
                        int videoIndex = rand.Next(1, videoLength-1);
                        Console.WriteLine("videoIndex: " + videoIndex);
                        return (Question)videogameQuestions[videoIndex];
                }
                return null;
        }
    }
}
