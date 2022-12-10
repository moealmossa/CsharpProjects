using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello what is your name?");
            string name = Console.ReadLine();
            if(name == "mansor")
            {
                Console.WriteLine($"hello {name} you are a professor");
            } else
            {
                Console.WriteLine($"hello {name} you are a student");
            }
        }
    }
}