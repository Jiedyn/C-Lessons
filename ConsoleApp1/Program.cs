using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C# Lesson 1";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            Console.WriteLine("You there!\nWhats your Name?");
            Console.ReadLine();

            Console.WriteLine("Its great to have you onboard cadet, You ready for your first mission?");
            Console.ReadLine();

            Console.WriteLine("Great! Meet me here at first light,");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dismissed");


            Console.ReadKey();
        }
    }
}
