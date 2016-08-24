using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Entities
{
    
    [KnownType(typeof(Store))]
    [DataContract]
    public class BaseEntity
    {
        [DataMember]
        public virtual int Id { get; set; }

    }
}
