using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            int A, B, C, D, dif;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + dif);
        }
    }
}
