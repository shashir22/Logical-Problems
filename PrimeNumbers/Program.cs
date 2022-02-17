using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public int Number;
        public int var_k;
        public int LastReminder = 0;
        public void CheckPrimeNumber()
        {
            Console.WriteLine("Enter a Number"); //Input Number
            Number = Convert.ToInt32(Console.ReadLine());//Read Number

            for (var_k = 2; var_k <= Number / 2; var_k++) //loop starts from 2 and check 2 <= Number den increment
            {
                if (Number % var_k == 0)  //If Number is % of 2 == 0 or 1
                    LastReminder = 0;
                else
                    LastReminder = 1;
            }
            if (LastReminder == 0) //if remainder is == 0 den it is a prime no other wise is not a prime no 
                Console.WriteLine("not Prime");
            else
                Console.WriteLine("Prime");
        }
    }
}