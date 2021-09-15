using System;
using System.Collections.Generic;
using System.Text;

namespace Batch34_Day3
{
    class With_outParam
    {
        static int fun(int x,int y,out int add,out int sub)
        {
            add = x + y;
            sub = x - y;
            return x * y;
        }
        static void Main(string[] args)
        {
            int add, sub;
            int x = 99, y = 77;
            int prod=fun(x,y,out add, out sub);
            Console.WriteLine("ADD = " + add);
            Console.WriteLine("SUB = " + sub);
            Console.WriteLine("PROD = " + prod);

        }
    }
}
