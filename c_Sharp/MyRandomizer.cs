using System;
using System.Collections.Generic;
using System.Text;

namespace c_Sharp
{
    public interface IRandomizeable
    {
        double GetRandomNo(double no);
    }


  public class MyRandomizer : IRandomizeable
    {
        public MyRandomizer()
        {

        }
        public double GetRandomNo(double no)
        {
            Random random = new Random();
            var seed = random.NextDouble();
            return seed * no;
        }
    }

    public class some
    {
         static void Main(string[] args)
        {
            MyRandomizer myRandomizer = new MyRandomizer();

            string str = string.Empty;
            do
            {
                Console.WriteLine("Enter No for Upper Bound");
                str = Console.ReadLine();
                try
                {
                    double upperDouble = Double.Parse(str);
                    Console.WriteLine($"Randone No between 0 to 1 {myRandomizer.GetRandomNo(upperDouble)} {upperDouble}");
                }
                catch (Exception)
                {

                }
            } while (str.ToLower()!="exist");

            Console.WriteLine("Hit Enter to Contine..");

            Console.ReadKey();
        }
    }

}
