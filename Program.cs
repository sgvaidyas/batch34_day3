using System;

namespace Batch34_Day3
{
    class Program
    {
        //call by reference
        //a=10 b=20
        static void swap(ref int a, ref int b)
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
            swap(ref m, ref n);//swap(ref 10,ref 20)
            Console.WriteLine("\nInside MAIN function after SWAP a=" + m + "  b=" + n);
        }
    }
}
