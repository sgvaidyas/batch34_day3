using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day3
{
    class CallbyValue
    {

        //call by value
        //a=10 b=20
        static void swap(int a, int b)
        {
            int temp;
            temp = a;//temp=10
            a = b;  //a=20
            b = temp;//b=10
            Console.WriteLine("\nInside SWAP function with value a=" + a + "  b=" + b);
        }
        static void Main(string[] args)
        {
            int m = 10, n = 20;
            Console.WriteLine("Inside MAIN function before SWAP a=" + m + "  b=" + n);
            swap(m, n);//swap(10,20)
            Console.WriteLine("\nInside MAIN function after SWAP a=" + m + "  b=" + n);
        }
    }
}
