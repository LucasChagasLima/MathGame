using System;
using MathGame.Engine;

Console.WriteLine("");
Console.WriteLine("Welcome to the MathGame!");

Console.WriteLine("______________________________");
Console.WriteLine("");
int choice;

do
{
    Console.WriteLine("Choce one option: ");
    Console.WriteLine("1 - Sun");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Multiplication");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - Last Games");
    Console.WriteLine("6 - Finish the game");
    
    Console.WriteLine("______________________________");
    Console.WriteLine("");
    Console.WriteLine("Your Choice: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Solve the sun: ");
            GameEngine game = new GameEngine();
            int num1 = game.NumRandom1;
            int num2 = game.NumRandom2;
            Console.WriteLine(num1 + " + " + num2 + " =");
            Console.Write("Your Answer: ");
            int answer = int.Parse(Console.ReadLine());
            int sun = game.Sun();
            if (answer != sun)
            {
                Console.WriteLine("Wrong! The correct answer is: " + sun);
                Console.WriteLine("");
                Console.WriteLine("______________________________");


            }
            else
            {
                Console.WriteLine("You Got It Right! The answer is: " + sun);
                Console.WriteLine("");
                Console.WriteLine("______________________________");


            }

            break;

    }

} while (choice != 6);

