using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day3
{
    class MinArray
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
        static int minArray(int[] a)
        {
            int ind, min;
            ind = 0;
            min = a[ind];
            for(int i=1;i<a.Length;i++)
            {
                if(a[i]<min)
                {
                    min = a[i];
                    ind = i;
                }
            }
            return ind;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter no of elements =");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            inputArray(a);
            displayArray(a);
            int min_ind = minArray(a);
            Console.WriteLine("Minimum element = "+ a[min_ind] + " at index = " + min_ind);
        }
    }
}
