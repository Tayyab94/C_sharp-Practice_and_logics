using System;
using System.Net;
using System.Net.Http;

namespace c_Sharp
{
    class Program
    {



        static unsafe void Main(string[] args)
        {
            //Convert_1D_into_2D array = new Convert_1D_into_2D();

            //array.Conversion(2, 2);

            //Console.ReadKey();
            var Client = new WebClient();
            var text = Client.DownloadString("https://www.fiverr.com");

            Console.WriteLine(text);
            Console.ReadKey();

        }
    }
}
