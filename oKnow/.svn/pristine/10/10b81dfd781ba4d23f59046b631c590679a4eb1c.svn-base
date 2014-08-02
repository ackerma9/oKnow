using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace OKnow.UI
{
    public class KeyDownEvent : IOEvent
    {
        Keys key;

        public KeyDownEvent(Keys key)
        {
            this.key = key;
        }

        public bool HasOccured(IOState current, IOState previous)
        {
            return current.KeyBoardState.IsKeyDown(key);
        }

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

        public override int GetHashCode()
        {
            return 3;
        }
    }
}
