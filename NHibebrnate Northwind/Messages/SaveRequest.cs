using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Entities;

namespace Messages
{
    [MessageContract]
    public class SaveRequest
    {
        [MessageBodyMember]
        public Person Item { get; set; }

        [MessageBodyMember]
        public long Owner { get; set; }
}
}
