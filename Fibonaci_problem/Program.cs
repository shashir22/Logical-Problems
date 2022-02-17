using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Program1
    {
        public static void FibonacciSeries()
        {
            int a = 0, b = 1, c = 0;
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}