// Day 4 of 100 - Rock, Paper, Scissors

string rock = @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";
string paper = @"
    _______
---'   ____)____
          ______)
          _______)
         _______)
---.__________)
";
string scissors = @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
";

bool playAgain = true;
Random random = new Random();
Console.WriteLine("Welcome to the Rock, Paper, Scissors game!");

while (playAgain)
{
    int computerChoice = random.Next(1, 4);
    Console.Write("Enter 1 for rock, 2 for paper, 3 for scissors: ");
    int playerChoice = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nYou chose:\n");
    if (playerChoice == 1)
        Console.WriteLine(rock);
    else if (playerChoice == 2)
        Console.WriteLine(paper);
    else
        Console.WriteLine(scissors);

    Console.WriteLine("\nThe computer got:\n");
    if (computerChoice == 1)
        Console.WriteLine(rock);
    else if (computerChoice == 2)
        Console.WriteLine(paper);
    else
        Console.WriteLine(scissors);

    FindTheWinner(playerChoice, computerChoice);

    Console.Write("\nDo you want to play again? Y or N: ");
    string keepPlaying = Console.ReadLine();
    if (keepPlaying == "N")
        playAgain = false;
    else
        continue;
}



void FindTheWinner(int player, int computer)
{
    if (player == computer)
    {
        Console.WriteLine("It's a draw.");
    }
    else if (player == 1 && computer == 3) // Player Rock, computer scissors
    {
        Console.WriteLine("Rock beats scissors. You win!");
    }
    else if (player == 3 && computer == 2) // Player scissors, computer paper
    {
        Console.WriteLine();
    }
    else if (player == 2 && computer == 1) // Player paper, computer rock
    {
        Console.WriteLine("Paper beats rock. You win!");
    }
    else if (computer == 1 && player == 3) // Computer Rock, player scissors
    {
        Console.WriteLine("Rock beats scissors. You lose!");
    }
    else if (computer == 3 && player == 2) // Computer scissors, player paper
    {
        Console.WriteLine("Scissors beats paper. You lose!");
    }
    else if (computer == 2 && player == 1) // Computer paper, player rock
    {
        Console.WriteLine("Paper beats rock. You lose!");
    }
}
