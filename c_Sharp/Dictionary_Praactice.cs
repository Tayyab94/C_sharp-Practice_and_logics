using System;
using System.Collections.Generic;
using System.Text;

namespace c_Sharp
{
    class Dictionary_Praactice
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> file = new Dictionary<string, string>();

            file.Add("html", "This is html file");

            file.Add("css", "This is css file");
            file.Add("php", "This is php file");
            file.Add("json", "This is json file");

            try
            {

                file.Add("html", "This is html file");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            foreach (KeyValuePair<string,string> k in file)
            {
                Console.WriteLine($"Key => {k.Key}, value =>{k.Value}");
            }
            Console.ReadKey();
        }
    }
}
