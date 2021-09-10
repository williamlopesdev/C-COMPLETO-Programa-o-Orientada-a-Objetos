using System;

namespace Timespans
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);


        }
    }
}
