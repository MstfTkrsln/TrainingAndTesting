using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Entities
{
    [DataContract]
   public class Person
    {
        [DataMember]
        public virtual long Id { get; set; }
        [DataMember]
        public virtual string Name { get; set; }
        
    }
}
