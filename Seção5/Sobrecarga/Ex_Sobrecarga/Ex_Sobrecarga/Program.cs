using System;
using System.Globalization;

namespace Ex_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Melhoria
            //criar um construtor opcional, o qual recebe apenas nome e
            //preço do produto.A quantidade em estoque deste novo produto, por
            //padrão, deverá então ser iniciada com o valor zero.

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto(); // argumento default

            Produto p3 = new Produto { Nome = "TV", Preco = 500.00, Quantidade = 20 }; // instanciando obrigatoriamente sem construtor

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
