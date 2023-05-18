// Day 2 of 100 - Tip Calculator

Console.WriteLine("Welcome to the Tip Calculator!");

Console.Write("What was the total bill? $");
double totalBill = Convert.ToDouble(Console.ReadLine());

Console.Write("What percentage tip would you like to give? 10, 12, or 15? ");
double tipPercentage = Convert.ToDouble(Console.ReadLine());

Console.Write("How many people split the bill? ");
double splitAmount = Convert.ToDouble(Console.ReadLine());

double amountPerPerson = Math.Round((totalBill / splitAmount) * (1 + (tipPercentage / 100)),2);

Console.WriteLine($"Each person should pay: ${amountPerPerson}");
