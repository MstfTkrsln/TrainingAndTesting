using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Gnip.Powertrack
{
    public class TalkwalkerStreamReader
    {
        // size of read block - larger is more efficient, but smaller is better for less active streams.  
        // 1600 is rough average size of activities.

        const int Blocksize = (10 * 1600);
        private HttpWebRequest _request;
        private AsyncCallback _asyncCallback;

        private string _streamName = "";
        // private StringBuilder rawBlock = new StringBuilder();

        private string accessToken =  @"39520b9d-a3db-47dc-971e-4e8f431c2a93_byfN0ela7x9ODgYTQPLlziyxQo3ktfEWkBAoWojaoeOV7euS-IF9avYjVzp3fkK4ZY4nxXyHsS-cInOr66VFRROIbsxl95esDLeqNyIT739HaDXaRBQuB8qHw2D4kgkdb7scjHSzPK8ys.cOv3EgzUQWnytvQ8W9qG.ujpKWAAQ";



        public bool Connect(string streamName)
        {

            // store stream name in class variable for use by performance counter
            _streamName = streamName;
            _shutDown = false;

            // form URL based on parameters
            var url = @"https://api.talkwalker.com/api/v2/stream/s/"+streamName+"/results?access_token="+accessToken;

            _request = (HttpWebRequest)WebRequest.Create(url);
            _request.Method = "GET";

            
            // set stream parameters
            //_request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            //_request.Headers.Add("Accept-Encoding", "gzip");
            _request.Accept = "application/json";
            _request.ReadWriteTimeout = 30000;
            _request.AllowReadStreamBuffering = false;

            _request.Timeout = 30; //seconds, PowerTrack sends 15-second heartbeat.
            _asyncCallback = HandleResult;    //Setting handleResult as Callback method...
            _request.BeginGetResponse(_asyncCallback, _request);    //Calling BeginGetResponse on 
            
            return true;
        }

        private bool _shutDown;
        public void Disconnect()
        {
            _shutDown = true;
        }
     
       
        private void HandleResult(IAsyncResult result)
        {

            try
            {
                using (var response = (HttpWebResponse) _request.EndGetResponse(result))
                using (var stream = response.GetResponseStream())
                using (var memory = new MemoryStream())
                {
                            
                    byte[] compressedBuffer = new byte[Blocksize];

                    if (stream != null && !stream.CanRead)
                    {
                        Debug.WriteLine(" --- Cannot Read Stream");
                        
                    }

                    while (stream != null && stream.CanRead)
                    {

                        try
                        {
                            int readCount = stream.Read(compressedBuffer, 0, compressedBuffer.Length);

                            // if readCount is 0, then the stream must have disconnected.  Process and abort!
                            if (readCount == 0)
                            {
                               break;
                            }
                            
                            if (readCount != 2)
                            {
                                var outputString = Encoding.UTF8.GetString(compressedBuffer.Take(readCount).ToArray());
                                Console.WriteLine(outputString);
                                File.AppendAllText("c:\\test.json", outputString);
                            }


                        }
                        catch (Exception error)
                        {
                           Console.WriteLine(error);
                        }
                        memory.SetLength(0);

                        // got signal to shut down.  Don't notify of disconnect.
                        if (_shutDown) break;
                    }
                    if (stream != null && !stream.CanRead)
                    {
                       Console.WriteLine("Can't Read Stream");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       
        ///// <summary>
        ///// Takes block of data that has been read from the stream and processes it into Activities
        ///// </summary>
        ///// <param name="outputString"></param>
        //protected virtual void ProcessBlock(string outputString)
        //{
            
        //    try
        //    {
        //        rawBlock.Append(outputString);

        //        // parse the block into an array of strings
        //        string[] rows = rawBlock.ToString().Split(new[] {Environment.NewLine}, new StringSplitOptions());
        //        rawBlock.Clear();  // reset rawBlock

        //        // process each line of the array
        //        for (var row = 0; row < rows.Length; row++)
        //        {
        //            var rawText = rows[row];
        //            if (rawText.Length > 0)
        //            {
        //                Activity activity;
        //                if (TryDeserializeActivity(rawText, out activity))
        //                {
        //                    try
        //                    {
        //                        if (OnActivityReceived != null) OnActivityReceived(this, activity);
        //                        if (OnJsonReceived != null) OnJsonReceived(this, rawText);

        //                        _activitiesPerSec.Increment();
        //                        _activitiesReceived ++;
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        Debug.WriteLine("General error in activity processing - row " + row + " of block " + rows.Length + " :" + rawText);
        //                        if (OnReaderExeception != null)
        //                            OnReaderExeception(this, new ApplicationException("Activity processsing error:" + rawText + " message= " + ex.Message));
        //                    }
        //                }
        //                else
        //                // not a valid Activity record
        //                {
        //                    // is it the first or last row?  if so, pass it on to the next block.
        //                    if (row == (rows.Length - 1)) rawBlock.Append(rawText);

        //                    // otherwise surface as an exception
        //                    else
        //                    {
        //                        // unless it's the first row, which may contain incomplete data (the first time)
        //                        if (row != 0)
        //                        {
        //                            Debug.WriteLine("Unknown text in line " + row + " of " + rows.Length + " :" + rawText);
        //                            if (OnReaderExeception != null) OnReaderExeception(this, new ApplicationException(rawText));
        //                        }
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                // blank line?  should be a heart beat.  Usually first row.
        //                Debug.WriteLine("*** Heartbeat on line " + row + " of " + rows.Length);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("Unknown Error in streamreader:" + ex.Message);
        //        if (OnReaderExeception != null) OnReaderExeception(this, new ApplicationException(ex.Message));
        //    }
        //}

        //// determines if a row of text can be converted to an activity record, returning true if possible, false if exception generated.
        //private bool TryDeserializeActivity(string rawText, out Activity activity)
        //{
        //    // does it end in a }?  If not, return false instead of attempting deserialize
        //    if (rawText.EndsWith("}"))
        //    try
        //    {
        //        activity = JsonConvert.DeserializeObject<Activity>(rawText);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        // ignored
        //    }
        //    activity = null;
        //    return false;
        //}
    }
}