using Course.Entities;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os dados de uma reserva de hotel(número do quarto, data
            //de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
            //dias.Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
            //novamente a reserva com os dados atualizados. O programa não deve aceitar dados
            //inválidos para a reserva, conforme as seguintes regras:
            //-Alterações de reserva só podem ocorrer para datas futuras

            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("check in date (aa/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("check out date(aa / MM / yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("check in date (aa/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("check out date(aa / MM / yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);
                if(error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }

            }
        }
    }
}
