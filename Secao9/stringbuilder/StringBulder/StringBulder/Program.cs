using System;
using StringBulder.Entities;


namespace StringBulder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancie manualmente os objetos mostrados abaixo e mostre-OperatingSystem na tela do terminal

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that´s awesome!");

            Post p1 = new Post(
                DateTime.Parse("12/09/2021 10:10:43"),
                "Traveling to new Zeland",
                "I'm going to visit this wonderful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good nigth!");
            Comment c4 = new Comment("May the force be with you!");

            Post p2 = new Post(
                DateTime.Parse("12/09/2021 13:15:43"),
                "Good nigth guys",
                "See you tomorrow",
                5);


            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
