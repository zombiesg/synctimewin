using System;
using System.Globalization;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace synctimewin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    WebRequest request = WebRequest.Create("http://worldtimeapi.org/api/ip");
                    request.Credentials = CredentialCache.DefaultCredentials;
                    WebResponse response = request.GetResponse();

                    using (Stream dataStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);
                        string responseFromServer = reader.ReadToEnd();
                        dynamic stuff = JsonConvert.DeserializeObject(responseFromServer);
                        string TempDate = stuff.datetime;

                        //"CultureInfo.InvariantCulture" for dynamic change date format
                        DateTime oDate = DateTime.Parse(TempDate, CultureInfo.InvariantCulture);
                        string strCmdText;
                        strCmdText = $"/C date {oDate.ToShortDateString()} & time {oDate.ToLongTimeString()}";
                        System.Diagnostics.Process.Start("CMD.exe", strCmdText);         
                    }
                    response.Close();
                    break;
                }
                catch
                {
                    //Console.WriteLine("error");
                    System.Threading.Thread.Sleep(5000);
                }
            }
            //Console.ReadKey();
        }
    }
}
