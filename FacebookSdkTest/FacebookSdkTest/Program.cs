using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Facebook;

namespace FacebookSdkTest
{
    class Program
    {
        static void Main(string[] args)
        {


            FacebookClient client=new FacebookClient();

            HttpWebRequest request = HttpWebRequest.CreateHttp("https://www.facebook.com/m.tekeraslan");

           Facebook.HttpWebRequestWrapper wrapper=new HttpWebRequestWrapper(request);

            var response = wrapper.GetResponse();
            




        }
    }
}
