using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SchoolServiceLibrary
{
    [DataContract]
    [KnownType(typeof(Graduate))]
    public class Student
    {
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
        [DataMember]
        public Status Status { get; set; }
    }
    [DataContract]
    public class Graduate:Student
    {
        [DataMember]
        public string Department { get; set; }
    }

    [DataContract]
    public enum Status
    {
        [EnumMember]
        Active,
        [EnumMember]
        Pasive,
        [EnumMember]
        None
    }
}
