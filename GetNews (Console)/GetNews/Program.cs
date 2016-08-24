using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace GetNews
{
    class Program
    {
        static void Main(string[] args)
        {
            string newsLink =
                "http://webtv.hurriyet.com.tr/2/64777/26503814/hayvanat-bahcesinde-ilginc-olay";


            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(newsLink);
          
            WebResponse myResponse = myRequest.GetResponse();


            StreamReader sr = new StreamReader(myResponse.GetResponseStream());
            string result = sr.ReadToEnd();

            int titleIndexBaslangici = result.IndexOf("<title>") + 7; //7
            int titleIndexBitisi = result.Substring(titleIndexBaslangici).IndexOf("</title>"); //8

            string title = result.Substring(titleIndexBaslangici, titleIndexBitisi); //9
            Console.WriteLine(title);

            int bodyIndexBaslangici = result.IndexOf("<p");
            int bodyIndexBitisi = result.IndexOf("</p>");
           
            string body = result.Substring(bodyIndexBaslangici, bodyIndexBitisi-bodyIndexBaslangici);
            Console.WriteLine(body);



            Console.ReadLine();
            sr.Close();
            myResponse.Close();

        }
    }
}
