
Console.WriteLine("How old are you?");

string ageText = Console.ReadLine();

int ageNumber = int.Parse(ageText);

Console.WriteLine($"my age will be {ageNumber + 25} but my age was {ageNumber - 25}");
