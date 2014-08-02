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
    
    public class Button : IOObserver
    {
        private Rectangle rectangle;
        private RectangleLeftClick click;

        public delegate void CallBack();

        private CallBack callBack;
        private String text;

        public static int Width
        {
            get { return (int)StaticTextures.Button.Width / 2; }
        }

        public Button(String text, Vector2 position, CallBack callBack)
        {
            this.callBack = callBack;
            this.text = text;

            rectangle = new Rectangle((int)(position.X), (int)(position.Y), Width, (int)StaticTextures.Button.Height / 2);
            click = new RectangleLeftClick(rectangle);
            IOSubject.AddObserver(click, this);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(StaticTextures.Button, rectangle, Color.White);

            SpriteFont font = StaticFonts.PericlesFont18;
            Vector2 textSize = font.MeasureString(text);
            Vector2 rectanglePosition = new Vector2(rectangle.X, rectangle.Y);
            Vector2 rectangleSize = new Vector2(rectangle.Width, rectangle.Height);
            Vector2 textPosition = rectanglePosition + rectangleSize / 2 - textSize / 2;

            spriteBatch.DrawString(font, text, textPosition, new Color(247, 150, 70));
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
