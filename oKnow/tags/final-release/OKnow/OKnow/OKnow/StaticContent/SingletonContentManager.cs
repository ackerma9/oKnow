using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
namespace OKnow.StaticContent
{
    /// <summary>
    /// Provides a static singleton reference to the content manager
    /// </summary>
    static class SingletonContentManager
    {
        private static ContentManager content;

        /// <summary>
        /// Initializes the content manager
        /// </summary>
        /// <param name="content">content manager</param>
        public static void Initialize(ContentManager content)
        {
            SingletonContentManager.content = content;
        }

        /// <summary>
        /// Returns the content manager
        /// </summary>
        public static ContentManager Content
        {
            get
            {
                if (content != null)
                {
                    return content;
                }
                else
                {
                    content = new ContentManager(Content.ServiceProvider, Content.RootDirectory);
                    return content;
                }
            }
        }
    }
}
