using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientApp.EmployeeService;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService.EmployeeServiceClient proxy = new EmployeeServiceClient("WSHttpBinding_IEmployeeService");


            foreach (var emp in proxy.GetEmployees())
            {
                Console.WriteLine(emp.EmployeeId+" "+emp.FirstName+" "+ emp.FirstName+" "+ emp.City);
            }

            Console.ReadLine();
        }
    }
}
