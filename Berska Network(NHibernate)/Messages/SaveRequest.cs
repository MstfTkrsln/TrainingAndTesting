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
        public BaseEntity store { get; set; }

       
        
    }
}
