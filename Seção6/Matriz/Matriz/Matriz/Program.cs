using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //imprime quantas posições a matriz tem

            Console.WriteLine(mat.Rank); //mostra a quantidade de linhas

            Console.WriteLine(mat.GetLength(0)); // quantidde de linhas da matriz

            Console.WriteLine(mat.GetLength(1));
        }
    }
}
