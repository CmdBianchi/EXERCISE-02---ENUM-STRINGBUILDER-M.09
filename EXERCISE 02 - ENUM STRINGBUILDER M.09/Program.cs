using System;
using EXERCISE_02___ENUM_STRINGBUILDER_M._09.Entities;
namespace EXERCISE_02___ENUM_STRINGBUILDER_M._09 {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {

            Comments c1 = new Comments("Have a nice trip!");
            Comments c2 = new Comments("Wow that's awesome!");
            Post p1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Traveling to New Zealand",
                    "I'm going to visit this wonderful country!",
                    12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comments c3 = new Comments("Good night");
            Comments c4 = new Comments("May the Force be with you");
            Post p2 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
