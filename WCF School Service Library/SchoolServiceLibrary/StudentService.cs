using System;
using System.Collections.Generic;

namespace SchoolServiceLibrary
{
    
    public class StudentService : IStudentService
    {

        public Student CreateStudent(string name, string surname, DateTime birthday)
        {
            Random rnd=new Random();

            return new Student(){Name = name,Surname = surname,Number = rnd.Next(1,100),Status = Status.Active,Birthday = birthday};
        }

        public List<Student> GetAllStudents(int departmentId)
        {
            return new List<Student>
            {
                new Student{Name="Mustafa",Surname = "Tekeraslan",Birthday = new DateTime(1989,1,1),Status = Status.Pasive},
                new Student{Name="Berk",Surname = "Turancı",Birthday = new DateTime(1988,7,5),Status = Status.Active},
                new Student{Name="Kamil",Surname = "Sönmez",Birthday = new DateTime(1975,6,2),Status = Status.None}
            };
        }


        public Student GetStudent(int number)
        {
            Graduate grd=new Graduate();
            grd.Name = "Beykan";
            grd.Surname = "Ucuncu";
            grd.Status = Status.Active;
            grd.Department = "Computer Programming";

            Student student = grd;

            return grd;
        }
    }
}
