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
    /// <summary>
    /// Implements an on screen button
    /// </summary>
    public class Button : BigText, IOObserver
    {
        private RectangleLeftClick click;

        public delegate void CallBack();
        private CallBack callBack;

        /// <summary>
        /// Constructs a button
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="position">position</param>
        /// <param name="callBack">Call back function</param>
        public Button(String text, Vector2 position, CallBack callBack) : base(text, position)
        {
            this.callBack = callBack;

            Rectangle rectangle = new Rectangle((int)(position.X), (int)(position.Y), Width, (int)StaticTextures.Button.Height / 2);
            click = new RectangleLeftClick(rectangle);
            IOSubject.AddObserver(click, this);
        }

        /// <summary>
        /// Notify event for IOObserver
        /// </summary>
        /// <param name="e">IOEvent</param>
        public void Notify(IOEvent e)
        {
            if (e.Equals(click))
            {
                callBack.Invoke();
            }
        }
    }
    
}
