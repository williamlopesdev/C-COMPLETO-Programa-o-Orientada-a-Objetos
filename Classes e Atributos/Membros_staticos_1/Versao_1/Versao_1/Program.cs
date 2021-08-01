using System;
using System.Globalization;

namespace Versao_1
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            // *****Versão 1: problema resolvido com metodos na propria classe do programa
            //Fazer um programa para ler um valor numérico qualquer, e daí mostrar
            //quanto seria o valor de uma circunferência e do volume de uma esfera
            //para um raio daquele valor. Informar também o valor de PI com duas
            //casas decimais.

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
