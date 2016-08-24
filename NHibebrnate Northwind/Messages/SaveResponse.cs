using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.ServiceModel;
using System.Text;
using Entities;

namespace Messages
{
    [MessageContract]
   public  class SaveResponse
    {
        [MessageBodyMember]
       public bool Result { get; set; }
        [MessageBodyMember]
       public Person Item { get; set; }


    }
}
