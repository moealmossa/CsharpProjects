using System;

namespace TypeCoverstionHomeWork 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you");
            string ageText = Console.ReadLine();

            int age = Convert.ToInt32(ageText);
            

            Console.WriteLine($"you will be {age+25} in 25 years,\n but you were {age-25} 25 years ago");

        }
    }
}