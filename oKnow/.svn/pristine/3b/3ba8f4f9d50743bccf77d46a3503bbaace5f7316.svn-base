using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace OKnow.UI
{
    /// <summary>
    /// Describes a Right Click Event
    /// </summary>
    class RightClickEvent : IOEvent
    {
        /// <summary>
        /// Returns true if a right click has occured
        /// </summary>
        /// <param name="current">current IO state</param>
        /// <param name="previous">previous IO state</param>
        /// <returns></returns>
        public virtual Boolean HasOccured(IOState current, IOState previous)
        {
            return current.MouseState.RightButton == ButtonState.Pressed && previous.MouseState.RightButton == ButtonState.Released;
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