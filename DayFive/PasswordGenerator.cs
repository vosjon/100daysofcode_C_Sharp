// Day 5 of 100 - Password Generator
/*
This one took much longer to build than the Python one.
Mainly has to do with my lack of knowledge of lists in C#
I was able to figure it out and this was a fun one to do. 
 */
 
char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
char[] symbols = { '!', '#', '$', '%', '&', '(', ')', '*', '+' };

Console.WriteLine("Welcome to the C# Password Generator!");
Console.WriteLine("How many letters would you like in your password?");
int numLetters = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many symbols would you like?");
int numSymbols = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many numbers would you like?");
int numNumbers = Convert.ToInt32(Console.ReadLine());

List<char> passwordList = new List<char>();
Random randomNumber = new Random();

for (int i = 0; i < numLetters; i++)
{
    int placeNumber = randomNumber.Next(0, letters.Length);
    passwordList.Add(letters[placeNumber]);
};

for (int i = 0; i < numLetters; i++)
{
    int placeNumber = randomNumber.Next(0, symbols.Length);
    passwordList.Add(symbols[placeNumber]);
};

for (int i = 0; i < numLetters; i++)
{
    int placeNumber = randomNumber.Next(0, numbers.Length);
    passwordList.Add(numbers[placeNumber]);
};

var randomizedPassword = passwordList.OrderBy(_ => randomNumber.Next()).ToList();

Console.Write("Your new password is: ");
Console.Write(String.Join("", randomizedPassword));
