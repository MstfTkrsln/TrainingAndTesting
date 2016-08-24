using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyServiceApp
{

    [ServiceContract(Name = "CustomerService",Namespace = "Http://wwww.Northwind.com/Services/CustomerService")]
    public interface ICustomerService
    {
        [OperationContract]
        List<Customer> GetCustomerByCountry(string country);

        [OperationContract]
        List<Customer> GetCustomerByName(string name);

        [OperationContract]
        void AddCustomer(string cumstomerId, string companyName, string address, string city);


    }

}