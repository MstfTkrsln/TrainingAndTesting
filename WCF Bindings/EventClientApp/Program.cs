using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventClientApp.EventConsumer;

namespace EventClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Başlamak için bir tuşa basınız...");
            Console.ReadLine();

            EventProviderClient client = new EventProviderClient("EventProviderWsHttpEndpoint");

            Content content=new Content(){Description = "Açıklama",Id = 1   };

            bool result = client.CreateEvent(content);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
