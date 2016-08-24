using System;
using System.Collections;
using Object_Pool_2;

namespace ObjectPooling
{
    internal class Program
    {
        public static void Main()
        {
            EmployeeFactory ef=new EmployeeFactory();

            Employee e1=ef.GetEmployee();
            Console.WriteLine(e1.FirstName+" "+e1.LastName);

            Employee e2 = ef.GetEmployee();
            Console.WriteLine(e2.FirstName+" "+e2.LastName);

            Employee e3 = ef.GetEmployee();
            Console.WriteLine(e3.FirstName + " " + e3.LastName);

            Employee e4 = ef.GetEmployee();
            Console.WriteLine(e4.FirstName + " " + e4.LastName);
            
            Console.ReadLine();

        }

        public class EmployeeFactory
        {

            //Defining Max pool size of Objects as two
            private static int _intMaxPoolSize = 2;

            //Collection class to hold objects
            private static readonly Queue objPool = new Queue(_intMaxPoolSize);

            //Creates new employee only when the count of objects is more than two
            //Otherwise served from pool



            public Employee GetEmployee()
            {
                Employee objEmployee;
                if (Employee._intCounter >= 2 && objPool.Count > 1)
                {
                    objEmployee = GetEmployeeFromPool();
                }
                else
                {
                    objEmployee = CreateNewEmployee();
                }
                return objEmployee;
            }

            private Employee GetEmployeeFromPool()
            {
                Employee objEmp;
                if (objPool.Count > 1)
                {
                    objEmp = (Employee) objPool.Dequeue();
                    Employee._intCounter--;
                }
                else
                {
                    objEmp = new Employee();
                }
                return objEmp;
            }

            private Employee CreateNewEmployee()
            {
                Employee objEmp = new Employee();
                objPool.Enqueue(objEmp);
                return objEmp;
            }
        }
    }
}