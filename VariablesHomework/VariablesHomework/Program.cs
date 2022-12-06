using System;
using System.Diagnostics.CodeAnalysis;

namespace VariablesHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "mohammed";
            int age = 22;
            bool alive = true;
            string phone = "626263878";

            Console.WriteLine($"My name is {name} and my is {age} and am I alive: {alive} but my phonenumber is: {phone}");

        }
    }

}

/* Create a console application that has variables to hold
 * a person's name, age, if they are alive, and their phone number.
 you do not need to capture these values from the user. */