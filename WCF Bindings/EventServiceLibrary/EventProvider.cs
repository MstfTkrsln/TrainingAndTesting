using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventServiceLibrary
{
    public class EventProvider:IEventProvider
    {
        public bool CreateEvent(Content content)
        {
            return true;
        }
    }
}
