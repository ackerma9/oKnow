using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow.Questions
{
    /// <summary>
    /// Category enum type 
    /// Every question has a category
    /// </summary>
    public enum Category
    {
        NONE = 0,
        MOVIES = 1,
        TVSHOWS = 2,
        MUSIC = 3,
        VIDEOGAMES = 4
    }

    /// <summary>
    /// Utility class for category functions
    /// </summary>
    public static class CatagoryUtils
    {
        private static Random rand = new Random(new System.DateTime().Millisecond);

        /// <summary>
        /// Gets a random category for use with a powerup
        /// </summary>
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
