using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.UI;

namespace OKnowTest.IOTests
{
    class MockIOObserver : IOObserver
    {

        private IOEvent e;

        private Boolean isNotified = false;
        public Boolean IsNotified
        {
            get { return isNotified; }
            set { isNotified = value; }
        }

        public MockIOObserver(IOEvent e)
        {
            this.e = e;
            IOSubject.AddObserver(e, this);
        }

        public void Notify(IOEvent e)
        {
            isNotified = true;
        }
    }
}
