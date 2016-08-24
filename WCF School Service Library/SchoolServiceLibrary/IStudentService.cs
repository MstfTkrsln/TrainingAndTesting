using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace SchoolServiceLibrary
{
   
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        Student CreateStudent(string name, string surname, DateTime birthday);

        [OperationContract]
        List<Student> GetAllStudents(int departmentId);

        [OperationContract]
        Student GetStudent(int number);
    }
}
