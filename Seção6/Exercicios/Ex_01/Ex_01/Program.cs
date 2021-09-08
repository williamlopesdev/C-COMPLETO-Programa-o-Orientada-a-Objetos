﻿using System;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro N e uma matriz de
            // ordem N contendo números inteiros. Em seguida, mostrar a diagonal
            //principal e a quantidade de valores negativos da matriz.

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagonal:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Negative Numbers: " + count);
            }
        }
    }
}
