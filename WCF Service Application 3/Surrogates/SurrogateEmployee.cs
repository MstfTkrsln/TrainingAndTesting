using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Surrogates
{
    [DataContract]
    public class SurrogateEmployee
    {
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string City { get; set; }
    }
}
