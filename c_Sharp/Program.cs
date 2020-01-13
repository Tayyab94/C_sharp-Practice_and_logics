using System;

namespace c_Sharp
{
    class Program
    {



        static unsafe void Main(string[] args)
        {
            //Convert_1D_into_2D array = new Convert_1D_into_2D();

            //array.Conversion(2, 2);

            //Console.ReadKey();

            DateTime dob;

            DateTime today = DateTime.Now;

            Console.WriteLine("Enter DOb ");
            dob = Convert.ToDateTime(Console.ReadLine()).Date;

            TimeSpan timeSpan =today.Subtract(dob);

            Console.WriteLine($"You are old {(timeSpan.Days / 365)}");

            Console.ReadKey();

        }
    }
}
