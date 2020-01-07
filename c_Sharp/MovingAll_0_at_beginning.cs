using System;
using System.Collections.Generic;
using System.Text;

namespace c_Sharp
{
    class MovingAll_0_at_beginning
    {
        public static void Main(string[] arg)
        {
            int[] arr = { 3, 5, 6, 7, 0, 3, 1, 0, -0, 1 };

            int count = arr.Length - 1;

            for (int i = count; i>=0; i--)
            {
                if(arr[i]!=0)
                {
                    arr[count] = arr[i];
                    count--;
                }

            }

            while (count>=0)
            {
                arr[count] = 0;
                count--;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
