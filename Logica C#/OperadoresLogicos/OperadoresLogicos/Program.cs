using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 4 != 5; // operador "E" true
            bool b1 = 2 > 3 && 4 != 5; // operador "E"
            bool a1 = 2 > 3 || 4 != 5;
            bool c2 = !(2 > 3) && 4 != 5; //true

            Console.WriteLine(c1);
            Console.WriteLine(b1);
            Console.WriteLine(a1);
            Console.WriteLine(c2);
            Console.WriteLine("------------------------------");

            bool c3 = 10 < 5; // false
            bool c4 = c1 || c2 && c3; // = true

            Console.WriteLine(c4);
        }
    }
}
