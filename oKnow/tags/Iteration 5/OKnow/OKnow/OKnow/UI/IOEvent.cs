using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKnow.UI
{
    public interface IOEvent
    {
        Boolean HasOccured(IOState current, IOState previous);


    }
}
