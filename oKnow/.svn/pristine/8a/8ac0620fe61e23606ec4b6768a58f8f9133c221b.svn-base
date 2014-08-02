using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace OKnow.UI
{
    public class RectangleLeftClick : LeftClickEvent
    {
        private Rectangle rectangle;
        public RectangleLeftClick(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }

        public override Boolean HasOccured(IOState current, IOState previous)
        {
            if (base.HasOccured(current, previous))
            {
                return rectangle.Contains(current.MouseState.X, current.MouseState.Y);
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if(obj.GetType() == this.GetType())
            {
                RectangleLeftClick other = (RectangleLeftClick)obj;
                return this.rectangle.X == other.rectangle.X && 
                    this.rectangle.Y == other.rectangle.Y &&
                    this.rectangle.Width == other.rectangle.Width &&
                    this.rectangle.Height == other.rectangle.Height;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 2;
        }
    }
}
