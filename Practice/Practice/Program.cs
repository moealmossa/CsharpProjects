
Console.WriteLine("How old are you?");
string ageText = Console.ReadLine();

int age = int.Parse(ageText);

//bool isValid = int.TryParse(ageText, out int age);



    Console.WriteLine($"you will be {age + 23} old in 23 years, an you were {age - 23} 23 years old");




Console.ReadLine();