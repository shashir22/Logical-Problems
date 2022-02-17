using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseANumber
    {
        public int Number;
        public int Reverse;
        public int Remainder;
        public void ReverseNumber()
        {
            Console.WriteLine("Enter a No. to reverse"); //input Number
            Number = int.Parse(Console.ReadLine()); //Read Number
            Reverse = 0; //By default Reverse will be 0
            while (Number > 0) //check in While If number is greater than 0
            {
                Remainder = Number % 10;  //Get the remainder by dividing the number with 10  
                Reverse = (Reverse * 10) + Remainder; //multiply the sum with 10 and then add the Reminder
                Number = Number / 10; // Get the quotient by dividing the number with 10
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}