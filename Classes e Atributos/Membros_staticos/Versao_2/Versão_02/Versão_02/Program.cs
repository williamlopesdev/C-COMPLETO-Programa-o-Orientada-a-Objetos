using System;
using System.Globalization;
using Versão_02;

namespace Versao_02

{
    class Program
    {
        static void Main(string[] args)
        {
            // *****Versão 1: problema resolvido com metodos na propria classe do programa
            //Fazer um programa para ler um valor numérico qualquer, e daí mostrar
            //quanto seria o valor de uma circunferência e do volume de uma esfera
            //para um raio daquele valor. Informar também o valor de PI com duas
            //casas decimais.


            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    
    }
}
