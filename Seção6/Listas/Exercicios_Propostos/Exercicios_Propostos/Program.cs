using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicios_Propostos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Fazer um programa para ler um número inteiro N e depois os dados(id, nome e salario) de
            //N funcionários.Não deve haver repetição de id.
            //Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            //Para isso, o programa deve ler um id e o valor X.Se o id informado não existir, mostrar uma
            //mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
            //conforme exemplos.
            //Lembre - se de aplicar a técnica de encapsulamento para não permitir que o salário possa
            //ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
            //aumento por porcentagem dada

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Empregados> list = new List<Empregados>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregados(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Empregados emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Empregados obj in list)
            {
                Console.WriteLine(obj);
            }
        

        }
    }
}
