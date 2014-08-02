using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.UI;

namespace OKnowTest.IOTests
{
    class MockIOEvent : IOEvent
    {
        private Boolean alwaysNotEqual;
        private Boolean occur = false;
        public Boolean Occur
        {
            get { return occur; }
            set { occur = value; }
        }

        public MockIOEvent(Boolean alwaysNotEqual)
        {
            this.alwaysNotEqual = alwaysNotEqual;
        }

        public bool HasOccured(IOState current, IOState previous)
        {
            return occur;
        }

        public override bool Equals(object obj)
        {
            if (alwaysNotEqual)
            {
                return obj == this;
            }

            return obj.GetType() == this.GetType();
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
