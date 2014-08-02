using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace OKnow.UI
{
    /// <summary>
    /// Encapsulates an instantanious state of input devices
    /// </summary>
    public class IOState
    {
        private MouseState mouseState;
        private KeyboardState keyBoardState;
        private GameTime gameTime;

        /// <summary>
        /// Constructs an IOState
        /// </summary>
        /// <param name="k">KeyboardState</param>
        /// <param name="m">MouseState</param>
        /// <param name="g">GameTime</param>
        public IOState(KeyboardState k, MouseState m, GameTime g)
        {
            keyBoardState = k;
            mouseState = m;
            gameTime = g;
        }

        /// <summary>
        /// Returns the mouse state
        /// </summary>
        public MouseState MouseState
        {
            get { return mouseState; }
        }

        /// <summary>
        /// Returns the keyboard state
        /// </summary>
        public KeyboardState KeyBoardState
        {
            get { return keyBoardState; }
        }

        /// <summary>
        /// Returns the game time of the state
        /// </summary>
        public GameTime GameTime
        {
            get { return gameTime; }
        }

        /// <summary>
        /// Constructs a IOState
        /// </summary>
        /// <param name="gameTime">current gameTime</param>
        public IOState(GameTime gameTime)
        {
            mouseState = Mouse.GetState();
            keyBoardState = Keyboard.GetState();
            this.gameTime = gameTime;
        }
    }
}
