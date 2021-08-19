using System;
using System.Globalization;

namespace Ex02_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro N e os dados(nome e
            //preço) de N Produtos.Armazene os N produtos em um vetor.Em
            //seguida, mostrar o preço médio dos produtos.

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            //instanciar cada um dos objetos em tipo classe

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("Preço médio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
