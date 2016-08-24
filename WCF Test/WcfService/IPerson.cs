using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IPerson
    {
        [OperationContract]
        Person GetPerson();

    }

    [DataContract]
    public class Person
    {

        private string name;
        private string surname;

        public Person()
        {
            name = "Mustafa";
            surname = "Tekeraslan";
        }

        [DataMember]
        public string Name{get { return name; } set { name = value; }}

        [DataMember]
        public string Surname{get { return surname; } set { surname = value; }}
    }
}
