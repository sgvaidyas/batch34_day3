using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day3
{
    class CallbyPointer
    {
        static unsafe void swap(int* a,int *b)
        {
            int temp;
            temp = *a;
            *a = *b;
            *b = temp;
            Console.WriteLine("SWAP FUN A = "+*a+" B = "+*b);
        }
        static unsafe void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("BEFORE SWAP FUN A = "+ a+ " B = "+ b);
            swap(&a, &b);
            Console.WriteLine("AFTER SWAP FUN A = "+ a+ " B = "+ b);
        }
    }
}
