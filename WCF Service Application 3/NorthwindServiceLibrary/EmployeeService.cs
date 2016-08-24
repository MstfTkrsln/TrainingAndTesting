using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NorthwindLibrary;
using Surrogates;

namespace NorthwindServiceLibrary
{
    public class EmployeeService : IEmployeeService
    {
        public SurrogateEmployee[] GetEmployees()
        {
            List<SurrogateEmployee> eployees = new List<SurrogateEmployee>();
            
            using (NorthwindEntities model = new NorthwindEntities())
            {
                
                eployees = (from e in model.Employees
                            select new SurrogateEmployee
                            {
                                City = e.City,
                                EmployeeId = e.EmployeeID,
                                FirstName = e.FirstName,
                                LastName = e.LastName
                            }
            ).ToList();
            }

            return eployees.ToArray();
        }
    }
}
