using System;

namespace c_Sharp
{
    class Program
    {
       


        static unsafe void Main(string[] args)
        {
            int a = 10;int b = 20;
            int* x = &a;  //Store the Address of A into X-Pointer 
            int* y = &b;   // Store the Address of B into y-Pointer
            Console.WriteLine("Before Swapping {0} - {1}", a, b);
            SwapNo no = new SwapNo();
            no.swap(x, y); // Swapping the Twno No.
            Console.WriteLine("after Swapping {0} - {1}", a, b);
            Console.ReadKey();

        }
    }
}
