using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow.UI;

namespace OKnowTest.IOTests
{
    [TestClass]
    public class IOSubjectTest
    {
        [TestMethod]
        public void TestUpdate()
        {
            IOSubject.Initialize();
            MockIOEvent mockEvent = new MockIOEvent(false);
            mockEvent.Occur = false;
            MockIOObserver mockObserver = new MockIOObserver(mockEvent);
            Assert.IsFalse(mockObserver.IsNotified);

            IOSubject.Update();
            Assert.IsFalse(mockObserver.IsNotified);

            mockEvent.Occur = true;
            IOSubject.Update();
            Assert.IsTrue(mockObserver.IsNotified);

            mockEvent.Occur = false;
            mockObserver.IsNotified = false;
            IOSubject.Update();
            Assert.IsFalse(mockObserver.IsNotified);
        }

        [TestMethod]
        public void TestUpdateEventEquality()
        {
            IOSubject.Initialize();
            MockIOEvent mockEvent1 = new MockIOEvent(false);
            MockIOEvent mockEvent2 = new MockIOEvent(false);
            mockEvent1.Occur = true;
            mockEvent2.Occur = false;

            MockIOObserver mockObserver1 = new MockIOObserver(mockEvent1);
            MockIOObserver mockObserver2 = new MockIOObserver(mockEvent2);

            IOSubject.Update();
            Assert.IsTrue(mockObserver1.IsNotified);
            Assert.IsTrue(mockObserver2.IsNotified);
        }

        [TestMethod]
        public void TestUpdateEventInequality()
        {
            IOSubject.Initialize();
            MockIOEvent mockEvent1 = new MockIOEvent(true);
            MockIOEvent mockEvent2 = new MockIOEvent(true);
            mockEvent1.Occur = true;
            mockEvent2.Occur = false;

            MockIOObserver mockObserver1 = new MockIOObserver(mockEvent1);
            MockIOObserver mockObserver2 = new MockIOObserver(mockEvent2);

            IOSubject.Update();
            
            Assert.IsTrue(mockObserver1.IsNotified);
            Assert.IsFalse(mockObserver2.IsNotified);
        }


    }
}
