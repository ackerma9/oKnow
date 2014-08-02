using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.StaticContent;
using OKnow.UI;

namespace OKnow.UI
{
    
    public class Button : BigText, IOObserver
    {
        private RectangleLeftClick click;

        public delegate void CallBack();
        private CallBack callBack;

        public Button(String text, Vector2 position, CallBack callBack) : base(text, position)
        {
            this.callBack = callBack;

            Rectangle rectangle = new Rectangle((int)(position.X), (int)(position.Y), Width, (int)StaticTextures.Button.Height / 2);
            click = new RectangleLeftClick(rectangle);
            IOSubject.AddObserver(click, this);
        }

        public void Notify(IOEvent e)
        {
            if (e.Equals(click))
            {
                callBack.Invoke();
            }
        }
    }
    
}
