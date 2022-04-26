using System;

namespace solotask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string last = Console.ReadLine();

            Console.Write($"Your name is {last}, {name} {last}.");

        }
    }
}