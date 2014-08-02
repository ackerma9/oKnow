using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow.UI
{
    public interface IOObserver
    {
        void Notify(IOEvent e);
    }
}
