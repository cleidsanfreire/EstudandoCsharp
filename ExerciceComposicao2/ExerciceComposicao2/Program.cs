using ExerciceComposicao2.Entities;
using System;

namespace ExerciceComposicao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c01 = new Comment("Have a nice trip!");
            Comment c02 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComment(c01);
            p1.AddComment(c02);

            Comment c11 = new Comment("Good Night!");
            Comment c12 = new Comment("May the Force be with you!");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys!",
                "See you tomorrow!",
                5);

            p2.AddComment(c11);
            p2.AddComment(c12);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}