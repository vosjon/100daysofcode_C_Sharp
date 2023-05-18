// Day 1 of 100 - Band Name Generator

Console.WriteLine("Welcome to the Band Name Generator!");

Console.Write("Yo dude, enter your name: ");
string name = Console.ReadLine();

Console.Write("What city did you grow up in? ");
string city = Console.ReadLine();

Console.Write("What is your pets name? ");
string petName = Console.ReadLine();

string bandName = city + " " + petName;

Console.WriteLine($"{name}, your gnarly band name is: {bandName}!");
