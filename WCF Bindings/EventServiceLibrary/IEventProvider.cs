using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.ServiceModel;
using System.Text;

namespace EventServiceLibrary
{
    [ServiceContract]
    public interface IEventProvider
    {
        [OperationContract]
        bool CreateEvent(Content content);
    }
}
