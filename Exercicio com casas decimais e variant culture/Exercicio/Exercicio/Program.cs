using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            //Minha solução
            Console.WriteLine(produto1 + ", cujo preço é: " + preco);
            Console.WriteLine(produto2 + "cujo preço é: " + preco2);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Registro:  {0} anos de idade, Codigo: {1}, genero:{2}.", idade, codigo, genero );
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Medida: {0:F8}", medida);
            Console.WriteLine("Medida: {0:F3}", medida);
            Console.WriteLine("Medida: {0:F3}", medida.ToString(CultureInfo.InvariantCulture));



            //Solução proposta
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco);
            Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código: {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
