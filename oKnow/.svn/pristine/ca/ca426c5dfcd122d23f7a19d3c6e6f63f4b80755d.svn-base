using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.UI;
using Microsoft.Xna.Framework.Input;

namespace OKnowTest
{
    [TestClass]
    public class KeyDownEventTest
    {
        [TestMethod]
        public void KeyIsDownEvent()
        {
            Keys[] pressedKeys = {Keys.A};
            KeyboardState keyBoardState = new KeyboardState(pressedKeys);

            IOState currentState = new IOState(keyBoardState, new MouseState(), null);
            IOEvent e = new KeyDownEvent(Keys.A);

            Assert.IsTrue(e.HasOccured(currentState, null));
        }

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
