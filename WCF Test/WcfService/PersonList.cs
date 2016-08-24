namespace WcfService
{
    public class Service1 : IPerson
    {
        public Person GetPerson()
        {
            return new Person();
        }

    }
}
