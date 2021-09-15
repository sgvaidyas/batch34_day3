using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day3
{
    class Function_Array
    {
        static void inputArray(int[] a)
        {
            int n = a.Length;
            for(int i=0;i<n;i++)
            {
                Console.Write("Enter the "+ i+" th element=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void displayArray(int[] a)
        {
            int n = a.Length;
            Console.WriteLine("\n\nArray elements = ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[" + i + "]="+a[i]);
            }
        }
        static int add(int[] a)
        {
            int sum = 0;
            foreach(int x in a)
                sum += x;

            return sum;

        }
        static void addition_2array(int[] a,int[] b,int[] c)
        {
            for(int i=0;i<a.Length;i++)
            {
                c[i] = a[i] + b[i];
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter no of elements =");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            inputArray(a);
            inputArray(b);

            displayArray(a);
            displayArray(b);
            //Console.WriteLine("Sum of array elements  = " + add(a));
            addition_2array(a, b, c);
            displayArray(c);
        }
    }
}
