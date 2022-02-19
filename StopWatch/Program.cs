using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Program6
    {
        public static void StopWatch()
        {

            long StartTimer;
            long StopTimer;
            Console.WriteLine("Press '1' to start time: ");
            StartTimer = long.Parse(Console.ReadLine());
            Console.WriteLine("Start Time is: " + StartTimer);
            StartTimer = StartTimer * 1000;

            Console.WriteLine("press '2' to stop time: ");
            StopTimer = long.Parse(Console.ReadLine());
            Console.WriteLine("Stop Time is: " + StopTimer);
            StopTimer = StopTimer * 1000;
            long elapsed = StopTimer - StartTimer;
            Console.WriteLine("total elapsed time(in millisecond) is :" + elapsed);



        }
    }
}