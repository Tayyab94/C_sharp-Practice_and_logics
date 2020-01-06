using System;
using System.Collections.Generic;
using System.Text;

namespace c_Sharp
{
   public class Convert_1D_into_2D
    {

        public int [] array{ get; set; }

        public Convert_1D_into_2D()
        {
            array = new int[] { 1, 2, 4, 5 };
        }


        public void Conversion(int r1, int c1)
        {
            int i = 0;
            int[,] two = new int[r1, c1];

            for (int x = 0; x < r1; x++)
            {
                for (int y = 0; y < c1; y++)
                {
                    two[x, y] = array[i];
                    i++;

                    Console.WriteLine(two[x, y]);
                }
            }
        }
    }
}
