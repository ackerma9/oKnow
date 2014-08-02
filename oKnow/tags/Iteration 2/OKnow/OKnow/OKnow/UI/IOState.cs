using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace OKnow.UI
{
    public class IOState
    {
        private MouseState mouseState;
        private KeyboardState keyBoardState;

        public MouseState MouseState
        {
            get { return mouseState; }
        }

        public KeyboardState KeyBoardState
        {
            get { return keyBoardState; }
        }

        public IOState()
        {
            mouseState = Mouse.GetState();
            keyBoardState = Keyboard.GetState();
        }
    }
}
