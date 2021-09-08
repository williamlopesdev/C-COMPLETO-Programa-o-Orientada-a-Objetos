using System;
using System.Globalization;

namespace Problema_com_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler as medidas dos lados de dois triângulos X e Y(suponha medidas
            //válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
            //possui a maior área.
            //A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
            //seguinte(fórmula de Heron):

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Area X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }

        }
    }
}
