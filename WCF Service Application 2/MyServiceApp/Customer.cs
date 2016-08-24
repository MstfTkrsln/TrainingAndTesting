using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyServiceApp
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string CustomerId  { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public string Country { get; set; }

        public override string ToString()
        {
            return CustomerId + " " + CompanyName + " " + Country;
        }
    }
}