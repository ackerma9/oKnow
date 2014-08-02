using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
namespace OKnow.StaticContent
{
    static class SingletonContentManager
    {
        private static ContentManager content;

        public static void Initialize(ContentManager content)
        {
            SingletonContentManager.content = content;
        }

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
