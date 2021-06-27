using System;
using StringBuilder.Entities;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nive trip =D");
            Comment c2 = new Comment("Wow that's awesome!!");
            Post p1 = new Post()
            {
                Moment = DateTime.Parse("21/06/2021 13:05:44"),
                Title = "Traveling to New Zeland",
                Content = "I'm going to visit this wonderful country",
                Likes = 12
            };
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the 4 be with you xD");
            Post p2 = new Post()
            {
                Moment = DateTime.Parse("21/06/2021 23:14:19"),
                Title = "Good night guys",
                Content = "See you tomorrow",
                Likes = 5
            };
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);


        }
    }
}
