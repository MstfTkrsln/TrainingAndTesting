using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NorthwindLibrary;

namespace MyServiceApp
{
    
    public class CustomerService : ICustomerService
    {
        NorthwindEntities modelEntities=new NorthwindEntities();

        public List<Customer> GetCustomerByCountry(string country)
        {
            List<Customer> customers=new List<Customer>();

            customers = (from c in modelEntities.Customers
                where c.Country == country
                select new Customer
                {
                    CompanyName = c.CompanyName,
                    Country = c.Country,
                    CustomerId = c.CustomerID
                }).ToList();


            return customers;
        }

        public List<Customer> GetCustomerByName(string name)
        {
            List<Customer> customers = new List<Customer>();

            customers = (from c in modelEntities.Customers
                         where c.CompanyName.ToUpper().Contains(name)
                         select new Customer
                         {
                             CompanyName = c.CompanyName,
                             Country = c.Country,
                             CustomerId = c.CustomerID
                         }).ToList();



            return customers;
        }


        public void AddCustomer(string customerId, string companyName, string address, string city)
        {

            NorthwindLibrary.Customer customer= NorthwindLibrary.Customer.CreateCustomer(customerId, companyName);

            customer.City = city;

            customer.Address = address;

            modelEntities.AddToCustomers(customer);


            modelEntities.SaveChanges();

            
        }
    }
}
