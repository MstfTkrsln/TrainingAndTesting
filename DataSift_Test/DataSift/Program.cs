using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSift;
using DataSift.Rest;
using Newtonsoft.Json;

namespace DataSift
{
    class Program
    {
        private static DataSiftClient _client;
        static void Main(string[] args)
        {
            _client = new DataSiftClient("ACCOUNT_API_USERNAME", "IDENTITY_APIKEY");
        }
    }
}
