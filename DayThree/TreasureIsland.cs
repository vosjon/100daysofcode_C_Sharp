// Day 3 of 100 - Treasure Island Game
Console.WriteLine(@"*******************************************************************************
          |                   |                  |                     |
 _________|________________.=""""_;=.______________|_____________________|_______
|                   |  ,-""_,=""""     `""=.|                  |
|___________________|__""=._o`""-._        `""=.______________|___________________
          |                `""=._o`""=._      _`""=._                     |
 _________|_____________________:=._o ""=._.""_.-=""'""=.__________________|_______
|                   |    __.--"" , ; `""=._o."" ,-""""""-._ "".   |
|___________________|_._""  ,. .` ` `` ,  `""-._""-._   "". '__|___________________
          |           |o`""=._` , ""` `; ."". ,  ""-._""-._; ;              |
 _________|___________| ;`-.o`""=._; ."" ` '`.""\` . ""-._ /_______________|_______
|                   | |o;    `""-.o`""=._``  '` "" ,__.--o;   |
|___________________|_| ;     (#) `-.o `""=.`_.--""_o.-; ;___|___________________
____/______/______/___|o;._    ""      `"".o|o_.--""    ;o;____/______/______/____
/______/______/______/_""=._o--._        ; | ;        ; ;/______/______/______/_
____/______/______/______/__""=._o--._   ;o|o;     _._;o;____/______/______/____
/______/______/______/______/____""=._o._; | ;_.--""o.--""_/______/______/______/_
____/______/______/______/______/_____""=.o|o_.--""""___/______/______/______/____
/______/______/______/______/______/______/______/______/______/______/_____ /
*******************************************************************************");

Console.WriteLine("Welcome to Treasure Island.");
Console.WriteLine("Your mission is to find the treasure.");

Console.WriteLine("You're at a cross road. Where do you want to go? Type \"left\" or \"right\"");
string crossRoadChoice  = Console.ReadLine();

if (crossRoadChoice == "left")
{
    Console.WriteLine("You come to a lake. There is an island in the middle. Type \"wait\" to wait for a boat. Type \"swim\" to swim.");
    string lakeChoice = Console.ReadLine();

    if (lakeChoice == "wait")
    {
        Console.WriteLine("You arive at the island unharmed. There is a house with three doors inside. One red, one yellow, and one blue. Which color do you choose?");
        string islandChoice = Console.ReadLine();

        if (islandChoice == "yellow")
        {
            Console.WriteLine("Congratulations! You found the treasure! You win the game.");
        }
        else if (islandChoice == "blue")
        {
            Console.WriteLine("You were eaten by a beast. GAME OVER!");
        }
        else if (islandChoice == "red")
        {
            Console.WriteLine("You were burned by fire. GAME OVER!");
        }
        else
        {
            Console.WriteLine("GAME OVER!");
        }
    }
    else
    {
        Console.WriteLine("You were attack by a giant trout. GAME OVER!");
    }
}
else
{
    Console.WriteLine("You fell into a hole. GAME OVER!");
}
