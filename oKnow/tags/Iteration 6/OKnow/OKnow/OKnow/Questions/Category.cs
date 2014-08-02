using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow.Questions
{
    public enum Category
    {
        NONE = 0,
        MOVIES = 1,
        TVSHOWS = 2,
        MUSIC = 3,
        VIDEOGAMES = 4
    }

    public static class CatagoryUtils
    {
        private static Random rand = new Random(new System.DateTime().Millisecond);
        public static Category RandomCatagory(Category currentCategory)
        {
            while (true)
            {
                Category randomCategory = (Category)rand.Next(1,5);
                if (randomCategory != currentCategory)
                {
                    return randomCategory;
                }
            }
        }
    }
}
