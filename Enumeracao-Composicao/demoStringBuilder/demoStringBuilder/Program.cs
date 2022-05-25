using System;
using demoStringBuilder.Entities;

namespace demoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Post 1
            //Instanciando comentários
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            //Criando Post
            Post p1 = new Post
            (
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderfoul country!",
                12);
            //Adicionando comentários ao Post
            p1.AddComent(c1);
            p1.AddComent(c2);

            //Post 2
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");

            Post p2 = new Post
            (
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            p2.AddComent(c3);
            p2.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
