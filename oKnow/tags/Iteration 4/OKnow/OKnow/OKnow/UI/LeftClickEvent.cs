﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace OKnow.UI
{
    class LeftClickEvent : IOEvent
    {
        public virtual Boolean HasOccured(IOState current, IOState previous)
        {
            return current.MouseState.LeftButton == ButtonState.Pressed && previous.MouseState.LeftButton == ButtonState.Released;
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        public override int GetHashCode()
        {
            return 1;
        }

    }
}