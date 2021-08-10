using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p; // tipo struct não precisa instanciar;
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
