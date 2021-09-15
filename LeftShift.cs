using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day3
{
    class LeftShift
    {
        static void inputArray(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the " + i + " th element=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void displayArray(int[] a)
        {
            int n = a.Length;
            Console.WriteLine("\n\nArray elements = \n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] +"\t");
            }
            Console.WriteLine();
        }
        static void leftshift(int[] a)
        {
            int n = a.Length, temp;
            temp = a[0];
            for (int i = 0; i < n - 1; i++)
                a[i] = a[i + 1];
            a[n - 1] = temp;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter no of elements =");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            inputArray(a);
            displayArray(a);
            leftshift(a);
            displayArray(a);
        }
    }
}
