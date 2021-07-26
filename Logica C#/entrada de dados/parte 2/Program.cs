using System;
using System.Globalization;

namespace dados2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); //converter string para int
            char ch = char.Parse(Console.ReadLine()); /// converter string para char
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //converte string para double. Sem o usisng globalization e o invariant, ele não converte o ".".

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);



            Console.WriteLine("voce digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));  //colocar o que está nos parenteses para converter para ponto na saida dos dados tb.
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
