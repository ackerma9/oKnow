using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OKnow.Questions
{
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

        public void addQuestion(Category category, String qString, String[] choices, Answer answer, QuestionType type)
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

        public void addMusicQuestion(Question question)
        {
            Category category = question.getCategory();
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

        public void addImageQuestion(Question question)
        {
            Category category = question.getCategory();
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

        public Question getRandQuestion(Category category)
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

        public Question getRandomMusicQuestion(Category category)
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

        public Question getRandomImageQuestion(Category category)
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
