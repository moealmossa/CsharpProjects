using System;

namespace MathGame // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void call()
        {
            Console.WriteLine("What is your name?");
            Console.ReadLine();
        }
        static void menu()
        {
            Console.WriteLine("What games do u wanna play?\nadd\nsubtract\nminus");
            Console.ReadLine();
        }
    }
}

//create a method that creates the username and then call inside the main method
//create a method called menu and this method is gonna greet the user and gives options on what games u wanna play 
