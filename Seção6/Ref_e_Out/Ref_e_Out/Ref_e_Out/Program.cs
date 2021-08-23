using System;

namespace Ref_e_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            Calculator.Triple(ref a);
            Console.WriteLine(a);


            int b = 10;
            int triple2;
            Calculator.Triple2(b, out triple2);
            Console.WriteLine(triple2);

        }

    }
}
