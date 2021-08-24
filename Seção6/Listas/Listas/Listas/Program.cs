using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco"); // Adiciona Marco na posição 2

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count: " + list.Count); // tamanho da lista

            string s1 = list.Find(x => x[0] == 'A'); //Encontrar o primeiro valor da ocorrencia solicitada
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); // encontrar o ultimo valor da ocorrencia solicitada
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1); /// encontrar a primeira posição do valor da ocorrencia solicitada

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2); /// encontrar a primeira posição do valor da ocorrencia solicitada

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------------------"); // procura as 5 primeiras posições
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("-------------------"); //remove o valor informado
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2);
            Console.WriteLine("-------------------"); //remove o valor da posição informada
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("-------------------"); //remove o valor informado
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------"); //remove todos com o valor informado
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
