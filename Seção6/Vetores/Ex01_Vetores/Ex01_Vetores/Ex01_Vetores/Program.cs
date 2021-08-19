﻿using System;
using System.Globalization;

namespace Ex01_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um numero inteiro N e a altua de N pessoas
            //Armazenar as N alturas em um vetor.
            //Em seguida, mostrar a altura media dessas pessoas.

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Altura média = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
