using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InterpressTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            byte[] data=new byte[1000000];

            HttpWebRequest _request;

            _request = (HttpWebRequest)WebRequest.Create(@"https://s3-us-west-1.amazonaws.com/archive.replay.snapshots/snapshots/twitter/track/activity_streams/InterpressMedia/2016/02/23/20150120-20150121_jdqgek9kyg/2015/01/20/00/50_activities.json.gz?AWSAccessKeyId=AKIAJ5I4JJVPDA3OSPIQ&Expires=1458831561&Signature=ZgSwv5ckDJxezVchdoDKzF6b1%2Bo%3D");
            

            _request.Method = "GET";
            _request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            _request.Headers.Add("Accept-Encoding", "gzip");
            _request.Accept = "application/json";


            var response=_request.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                //stream.Read(data, 0, (int) response.ContentLength);


                GZipStream uncompressed = new GZipStream(stream, CompressionMode.Decompress);

                uncompressed.Write(data, 0, data.Length); // write all compressed bytes
                uncompressed.Flush();
                uncompressed.Close();


            }

            var outputString = Encoding.UTF8.GetString(data);



        }
    }
}
