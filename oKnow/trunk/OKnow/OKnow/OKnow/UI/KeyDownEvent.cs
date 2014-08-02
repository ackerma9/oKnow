using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;


namespace OKnow.UI
{
    /// <summary>
    /// Describes a key down event
    /// </summary>
    public class KeyDownEvent : IOEvent
    {
        Keys key;

        /// <summary>
        /// Constructs a key down event
        /// </summary>
        /// <param name="key">Key to watch</param>
        public KeyDownEvent(Keys key)
        {
            this.key = key;
        }

        /// <summary>
        /// Returns true if the key is down
        /// </summary>
        /// <param name="current">current IO state</param>
        /// <param name="previous">current IO state</param>
        /// <returns>true if the key is down</returns>
        public bool HasOccured(IOState current, IOState previous)
        {
            return current.KeyBoardState.IsKeyDown(key);
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

            if (obj.GetType() == this.GetType())
            {
                KeyDownEvent other = (KeyDownEvent)obj;
                return this.key == other.key;
            }
            return false;
        }

        /// <summary>
        /// Super complex hash function.  0% collisions
        /// </summary>
        /// <returns>3</returns>
        public override int GetHashCode()
        {
            return 3;
        }
    }
}
