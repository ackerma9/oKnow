using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace OKnow.UI
{
    /// <summary>
    /// Descibes a left click within a rectangle event
    /// </summary>
    public class RectangleLeftClick : LeftClickEvent
    {
        private Rectangle rectangle;
        /// <summary>
        /// Constructs a RectangleLeftClick event 
        /// </summary>
        /// <param name="rectangle">rectangle which can be clicked</param>
        public RectangleLeftClick(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }

        /// <summary>
        /// Returns true if the rectangle is clicked
        /// </summary>
        /// <param name="current">current IO state</param>
        /// <param name="previous">previous IO State</param>
        /// <returns>true if the rectangle is clicked</returns>
        public override Boolean HasOccured(IOState current, IOState previous)
        {
            if (base.HasOccured(current, previous))
            {
                return rectangle.Contains(current.MouseState.X, current.MouseState.Y);
            }

            return false;
        }

        /// <summary>
        /// Returns true if the events are equal
        /// </summary>
        /// <param name="obj">Other object</param>
        /// <returns>true if the events are equal</returns>
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

        /// <summary>
        /// Super complex hash function.  0% collisions
        /// </summary>
        /// <returns>2</returns>
        public override int GetHashCode()
        {
            return 2;
        }
    }
}
