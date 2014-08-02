using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.UI;
using Microsoft.Xna.Framework.Input;

namespace OKnowTest
{
    [TestClass]
    public class KeyDownEventTest
    {
		/// <summary>
        /// Tests for the key down event
        ///</summary>
        [TestMethod]
        public void KeyIsDownEvent()
        {
            Keys[] pressedKeys = {Keys.A};
            KeyboardState keyBoardState = new KeyboardState(pressedKeys);

            IOState currentState = new IOState(keyBoardState, new MouseState(), null);
            IOEvent e = new KeyDownEvent(Keys.A);

            Assert.IsTrue(e.HasOccured(currentState, null));
        }
		/// <summary>
        /// Tests for the state when a key is not pressed
        ///</summary>
        [TestMethod]
        public void KeyIsNotDownEvent()
        {

            Keys[] pressedKeys = { Keys.B };
            KeyboardState keyBoardState = new KeyboardState(pressedKeys);

            IOState currentState = new IOState(keyBoardState, new MouseState(), null);
            IOEvent e = new KeyDownEvent(Keys.A);

            Assert.IsFalse(e.HasOccured(currentState, null));
        }
    }
}
