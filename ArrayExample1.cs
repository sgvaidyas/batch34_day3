using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day3
{
    class ArrayExample1
    {
        static void inputArray(int[] a)
        {
            int n = a.Length, i, j,k;
            for (i = 1,j=n,k=0  ; k<n ; i++,j--,k+=2)
            {
                if (i != j)
                {
                    a[k] = i;
                    a[k + 1] = j;
                }
                else
                    a[k] = i;               
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
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter no of elements =");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            inputArray(a);
            displayArray(a);
        }
    }
}
