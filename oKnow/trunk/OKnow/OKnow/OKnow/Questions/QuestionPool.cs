using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OKnow.Questions
{
    /// <summary>
    /// Contains all the questions for a single game
    /// </summary>
    public class QuestionPool
    {
        public static int numCategories = 4;

        private ArrayList movieQuestions;
        private ArrayList tvshowQuestions;
        private ArrayList musicQuestions;
        private ArrayList videogameQuestions;

        private ArrayList movieMusicQuestions;
        private ArrayList tvshowMusicQuestions;
        private ArrayList musicMusicQuestions;
        private ArrayList videogameMusicQuestions;

        private ArrayList movieImageQuestions;
        private ArrayList tvshowImageQuestions;
        private ArrayList musicImageQuestions;
        private ArrayList videogameImageQuestions;
        Random rand;
        Random musicRand;
        Random imageRand;

        /// <summary>
        /// Main constructor for the question pool
        /// </summary>
        public QuestionPool()
        {
            movieQuestions = new ArrayList();
            tvshowQuestions = new ArrayList();
            musicQuestions = new ArrayList();
            videogameQuestions = new ArrayList();

            movieMusicQuestions = new ArrayList();
            tvshowMusicQuestions = new ArrayList();
            musicMusicQuestions = new ArrayList();
            videogameMusicQuestions = new ArrayList();

            movieImageQuestions = new ArrayList();
            tvshowImageQuestions = new ArrayList();
            musicImageQuestions = new ArrayList();
            videogameImageQuestions = new ArrayList();

            rand = new Random();
            musicRand = new Random();
            imageRand = new Random();
        }

        /// <summary>
        /// Method to add a question to the question pool
        /// Based on its category type it will be added to the correct question pool
        /// This method is called when the game board is generated
        /// </summary>
        /// <param name="category"></param>
        /// <param name="qString"></param>
        /// <param name="choices"></param>
        /// <param name="answer"></param>
        /// <param name="type"></param>
        public void AddQuestion(Category category, String qString, String[] choices, Answer answer, QuestionType type)
        {
            Question question = new Question(category, qString, choices, answer, type);

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

        /// <summary>
        /// Method to add a music question to the question pool
        /// Based on its category type it will be added to the correct question pool
        /// This method is called when the game board is generated
        /// </summary>
        /// <param name="question"></param>
        public void AddMusicQuestion(Question question)
        {
            Category category = question.GetCategory();
            if (category == Category.MOVIES)
            {
                movieMusicQuestions.Add(question);
            }
            else if (category == Category.TVSHOWS)
            {
                tvshowMusicQuestions.Add(question);
            }
            else if (category == Category.MUSIC)
            {
                musicMusicQuestions.Add(question);
            }
            else if (category == Category.VIDEOGAMES)
            {
                videogameMusicQuestions.Add(question);
            }
        }

        /// <summary>
        /// Method to add a image question to the question pool
        /// Based on its category type it will be added to the correct question pool
        /// This method is called when the game board is generated
        /// </summary>
        /// <param name="question"></param>
        public void AddImageQuestion(Question question)
        {
            Category category = question.GetCategory();
            if (category == Category.MOVIES)
            {
                movieImageQuestions.Add(question);
            }
            else if (category == Category.TVSHOWS)
            {
                tvshowImageQuestions.Add(question);
            }
            else if (category == Category.MUSIC)
            {
                musicImageQuestions.Add(question);
            }
            else if (category == Category.VIDEOGAMES)
            {
                videogameImageQuestions.Add(question);
            }
        }

        /// <summary>
        /// Method to get a random Question from the correct question pool
        /// Seeds at different times to ensure randomness
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Question</returns>
        public Question GetRandQuestion(Category category)
        {
                switch(category)
                {
                    case Category.MOVIES:
                        int movieLength = movieQuestions.Count;
                        int movieIndex = rand.Next(0,movieLength);
                        return (Question)movieQuestions[movieIndex];

                    case Category.MUSIC:
                        int musicLength = musicQuestions.Count;
                        int musicIndex = rand.Next(0, musicLength);
                        return (Question)musicQuestions[musicIndex];

                    case Category.TVSHOWS:
                        int tvLength = tvshowQuestions.Count;
                        int tvIndex = rand.Next(0, tvLength);
                        return (Question)tvshowQuestions[tvIndex];

                    case Category.VIDEOGAMES:
                        int videoLength = videogameQuestions.Count;
                        int videoIndex = rand.Next(0, videoLength);
                        return (Question)videogameQuestions[videoIndex];
                }
                return null;
        }

        /// <summary>
        /// Method to get a random music Question from the correct question pool
        /// Seeds at different times to ensure randomness
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Question</returns>
        public Question GetRandomMusicQuestion(Category category)
        {
            switch (category)
            {
                case Category.MOVIES:
                    int movieLength = movieMusicQuestions.Count;
                    int movieIndex = musicRand.Next(0, movieLength);
                    return (Question)movieMusicQuestions[movieIndex];

                case Category.MUSIC:
                    int musicLength = musicMusicQuestions.Count;
                    int musicIndex = musicRand.Next(0, musicLength);
                    return (Question)musicMusicQuestions[musicIndex];

                case Category.TVSHOWS:
                    int tvLength = tvshowMusicQuestions.Count;
                    int tvIndex = musicRand.Next(0, tvLength);
                    return (Question)tvshowMusicQuestions[tvIndex];

                case Category.VIDEOGAMES:
                    int videoLength = videogameMusicQuestions.Count;
                    int videoIndex = musicRand.Next(0, videoLength);
                    return (Question)videogameMusicQuestions[videoIndex];
            }
            return null;
        }

        /// <summary>
        /// Method to get a random image Question from the correct question pool
        /// Seeds at different times to ensure randomness
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Question</returns>
        public Question GetRandomImageQuestion(Category category)
        {
            switch (category)
            {
                case Category.MOVIES:
                    int movieLength = movieImageQuestions.Count;
                    int movieIndex = imageRand.Next(0, movieLength);
                    return (Question)movieImageQuestions[movieIndex];

                case Category.MUSIC:
                    int musicLength = musicImageQuestions.Count;
                    int musicIndex = imageRand.Next(0, musicLength);
                    return (Question)musicImageQuestions[musicIndex];

                case Category.TVSHOWS:
                    int tvLength = tvshowImageQuestions.Count;
                    int tvIndex = imageRand.Next(0, tvLength);
                    return (Question)tvshowImageQuestions[tvIndex];

                case Category.VIDEOGAMES:
                    int videoLength = videogameImageQuestions.Count;
                    int videoIndex = imageRand.Next(0, videoLength);
                    return (Question)videogameImageQuestions[videoIndex];
            }
            return null;
        }
    }
}
