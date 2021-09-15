using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day3
{
    class Rightshift
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
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
        static void rightShift(int[] a)
        {
            int n = a.Length, temp;
            temp = a[n-1];
            for (int i = n-1; i >0; i--)
                a[i] = a[i - 1];
            a[0] = temp;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter no of elements =");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            inputArray(a);
            displayArray(a);
            rightShift(a);
            displayArray(a);
        }
    }
}
