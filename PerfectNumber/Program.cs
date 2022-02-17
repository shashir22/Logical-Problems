using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Program2
    {
        public static void PerfectNumber()
        {
            int n, i, sum;

            Console.WriteLine("Check whether a given number is perfect number or not");


            Console.WriteLine("Input the  number ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.WriteLine("The positive divisor ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}  ", i);
                }
            }
            Console.Write("The sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.WriteLine("the number is perfect.");
            else
                Console.WriteLine("the number is not perfect.");

        }


    }
}