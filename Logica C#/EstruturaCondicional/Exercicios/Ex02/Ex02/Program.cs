using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
