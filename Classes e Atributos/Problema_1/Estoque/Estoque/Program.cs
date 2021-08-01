﻿using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); 

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados " + p);


            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados " + p);
        }
    }
}
