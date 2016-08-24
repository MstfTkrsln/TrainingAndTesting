using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace ConsoleApplication2
{
    public static class Extensions
    {
        public static int ConvertToInt(this double val)
        {
            return (int)val;
        }

        public static string ConvertToString(this int val)
        {
            return val.ToString();
        }

        public static string ChangeToEnglishChars(this string val)
        {
            return val.Replace('ğ', 'g').Replace('İ', 'I');
        }
    }


   public static class Extensions2
    {
       public static IEnumerable<T> FindItemWhere<T>(this IEnumerable<T> list, Func<T, bool> func)
       {
           List<T> newList = new List<T>();
           foreach (var item in list)
               if (func(item))
                   newList.Add(item);
           return newList;
       }
       public  static int CountOfItems<T>(this IEnumerable<T> list)
       {
           int sayac = 0;
           foreach (var item in list)
               sayac++;
           return sayac;
       }
    }

    class Program
    {
       

        static void Main(string[] args)
        {
            List<Person> personList=new List<Person>();
            personList.Add(new Person() {Id = 5, Name = "hamza"});
            personList.Add(new Person() {Id = 10, Name = "ali"});
            personList.Add(new Person() {Id = 15,Name = "hamza"});
            personList.Add(new Person(){Id = 20,Name = "mustafa"});
            personList.Add(new Person() {Id = 25,Name = "murtaza"});


            List<Person> newpersonlist =(List<Person>) personList.FindItemWhere(x => x.Id>9 && x.Name.EndsWith("a") && x.Name.StartsWith("m"));

           // var retList = CountOfItems(FindItemWhere(personList, x => x.Name == "hamza"));
            
            foreach (var item in newpersonlist)
            {
                Console.WriteLine(item.Id+"\t"+item.Name);
            }
            
            Console.ReadLine();
            
        }

       //private static void DidPersons(List<Person> personList)
        //{
        //  var retList=  FindItemWhere(personList, x => x.Name == "hamza");
        //}

        private static void ExecutePersons(List<Person> personList)
        {
            Person p = null;
            foreach(var item in personList)
                if (item.Id == 5)
                {
                    p = item;
                    break;
                }
            if (p != null)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
