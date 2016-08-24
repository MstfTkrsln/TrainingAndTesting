using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryReader
{
    public class Person
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Age { get; set; }

        public Person(decimal id,string name,string surname,uint age)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Surname + " " + Age;
        }
    }
}
