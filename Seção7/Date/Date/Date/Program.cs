using System;
using System.Globalization;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;


            DateTime d2 = new DateTime(2021, 09, 08);
            DateTime d3 = new DateTime(2021, 09, 08, 20,  56, 30);
            DateTime d4 = new DateTime(2021, 09, 08, 20, 56, 30, 500);
            DateTime d5 = new DateTime(2021, 09, 08);

            DateTime d8 = DateTime.Parse("2000-08-15");

            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);

        }
    }
}
