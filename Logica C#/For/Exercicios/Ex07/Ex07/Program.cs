﻿using System;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
            //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            //exemplo

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}
