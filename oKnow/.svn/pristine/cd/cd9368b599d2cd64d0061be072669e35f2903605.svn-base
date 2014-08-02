using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace OKnow.UI
{
    public class IOState
    {
        private MouseState mouseState;
        private KeyboardState keyBoardState;
        private GameTime gameTime;

        public MouseState MouseState
        {
            get { return mouseState; }
        }

        public KeyboardState KeyBoardState
        {
            get { return keyBoardState; }
        }

        public GameTime GameTime
        {
            get { return gameTime; }
        }

        public IOState(GameTime gameTime)
        {
            mouseState = Mouse.GetState();
            keyBoardState = Keyboard.GetState();
            this.gameTime = gameTime;
        }
    }
}
