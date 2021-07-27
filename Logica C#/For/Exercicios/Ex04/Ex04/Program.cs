using System;
using System.Globalization;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            //segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel"

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
