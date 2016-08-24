using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using EventServiceLibrary;

namespace EventServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host=new ServiceHost(typeof(EventProvider));
            
            host.Opened += (o, e) =>
            {
                Console.WriteLine("Host Status : " + host.State);
            };

            host.Open();

          

            foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
            {
                Console.WriteLine("{0} {1}" ,endpoint.Address,endpoint.Name);
            }

            Console.WriteLine("Kapatmak için bir tuşa basınız...");
            Console.ReadLine();
            host.Close();
        }
    }
}
