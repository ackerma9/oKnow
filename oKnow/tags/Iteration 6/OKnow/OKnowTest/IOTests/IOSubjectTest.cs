using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.UI;
using Microsoft.Xna.Framework;
namespace OKnowTest.IOTests
{
    [TestClass]
    public class IOSubjectTest
    {
        [TestMethod]
        public void TestUpdate()
        {
            IOSubject.Initialize(new GameTime());
            MockIOEvent mockEvent = new MockIOEvent(false);
            mockEvent.Occur = false;
            MockIOObserver mockObserver = new MockIOObserver(mockEvent);
            Assert.IsFalse(mockObserver.IsNotified);

            IOSubject.Update(new GameTime());
            Assert.IsFalse(mockObserver.IsNotified);

            mockEvent.Occur = true;
            IOSubject.Update(new GameTime());
            Assert.IsTrue(mockObserver.IsNotified);

            mockEvent.Occur = false;
            mockObserver.IsNotified = false;
            IOSubject.Update(new GameTime());
            Assert.IsFalse(mockObserver.IsNotified);
        }

        [TestMethod]
        public void TestUpdateEventEquality()
        {
            IOSubject.Initialize(new GameTime());
            MockIOEvent mockEvent1 = new MockIOEvent(false);
            MockIOEvent mockEvent2 = new MockIOEvent(false);
            mockEvent1.Occur = true;
            mockEvent2.Occur = false;

            MockIOObserver mockObserver1 = new MockIOObserver(mockEvent1);
            MockIOObserver mockObserver2 = new MockIOObserver(mockEvent2);

            IOSubject.Update(new GameTime());
            Assert.IsTrue(mockObserver1.IsNotified);
            Assert.IsTrue(mockObserver2.IsNotified);
        }

        [TestMethod]
        public void TestUpdateEventInequality()
        {
            IOSubject.Initialize(new GameTime());
            MockIOEvent mockEvent1 = new MockIOEvent(true);
            MockIOEvent mockEvent2 = new MockIOEvent(true);
            mockEvent1.Occur = true;
            mockEvent2.Occur = false;

            MockIOObserver mockObserver1 = new MockIOObserver(mockEvent1);
            MockIOObserver mockObserver2 = new MockIOObserver(mockEvent2);

            IOSubject.Update(new GameTime());
            
            Assert.IsTrue(mockObserver1.IsNotified);
            Assert.IsFalse(mockObserver2.IsNotified);
        }


    }
}
