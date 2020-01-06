using System;
using System.Collections.Generic;
using System.Text;

namespace c_Sharp
{
   public class SwapNo
    {
        public unsafe void swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }

       
    }
}
