using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace OKnow.UI
{
    /// <summary>
    /// Describes a Left Click Event event
    /// </summary>
    public class LeftClickEvent : IOEvent
    {
        /// <summary>
        /// Returns true if the Left Click has occured
        /// </summary>
        /// <param name="current">current IO state</param>
        /// <param name="previous">current IO state</param>
        /// <returns>true if the Left Click has occured</returns>
        public virtual Boolean HasOccured(IOState current, IOState previous)
        {
            return current.MouseState.LeftButton == ButtonState.Pressed && previous.MouseState.LeftButton == ButtonState.Released;
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
            return obj.GetType() == this.GetType();
        }

        /// <summary>
        /// Super complex hash function.  0% collisions
        /// </summary>
        /// <returns>1</returns>
        public override int GetHashCode()
        {
            return 1;
        }

    }
}
