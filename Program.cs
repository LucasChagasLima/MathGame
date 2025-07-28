using System;
using MathGame.Engine;

Console.WriteLine("");
Console.WriteLine("Welcome to the MathGame!");

Console.WriteLine("______________________________");
Console.WriteLine("");
int choice;
List<string> history = new List<string>();

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
    Console.Write("Your Choice: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Solve the sun: ");
            GameEngine game = new GameEngine();
            string roundResult;
            int num1 = game.NumRandom1;
            int num2 = game.NumRandom2;
            Console.WriteLine(num1 + " + " + num2 + " =");
            Console.Write("Your Answer: ");
            int answer = int.Parse(Console.ReadLine());
            int sun = game.Sun();
            if (answer != sun)
            {
                roundResult = "Sun: " + num1 + " + " + num2 + " = " + sun + ". " + "Your Answer: " + answer + ". (Wrong)" ;
                Console.WriteLine("Wrong! The correct answer is: " + sun);
                Console.WriteLine("");
                Console.WriteLine("______________________________");


            }
            else
            {
                roundResult = "Sun: " + num1 + " + " + num2 + " = " + sun + ". " + "Your Answer: " + answer + ". (Correct)" ;
                Console.WriteLine("You Got It Right! The answer is: " + sun);
                Console.WriteLine("");
                Console.WriteLine("______________________________");


            }
            history.Add(roundResult);
            break;
        case 2:
            Console.WriteLine("Solve the Subtraction: ");
            GameEngine gameSub = new GameEngine();
            int numSub1 = gameSub.NumRandom1;
            int numSub2 = gameSub.NumRandom2;

            Console.WriteLine(numSub1 + " - " + numSub2 + " =");
            Console.Write("Your Answer: ");
            int answerSub = int.Parse(Console.ReadLine());
            int subtraction = gameSub.Subtraction();
            if (answerSub != subtraction)
            {
                roundResult = "Subtraction: " + numSub1 + " + " + numSub2 + " = " + subtraction + ". " + "Your Answer: " + answerSub + ". (Wrong)" ;
                Console.WriteLine("Wrong! The correct answer is: " + subtraction);
                Console.WriteLine("");
                Console.WriteLine("______________________________");


            }
            else
            {
                roundResult = "Subtraction: " + numSub1 + " + " + numSub2 + " = " + subtraction + ". " + "Your Answer: " + answerSub + ". (Correct)" ;
                Console.WriteLine("You Got It Right! The answer is: " + subtraction);
                Console.WriteLine("");
                Console.WriteLine("______________________________");


            }
            history.Add(roundResult);
            break;
        case 3:
            Console.WriteLine("Solve the Multiplication: ");
            GameEngine gameMult = new GameEngine();
            int numMult1 = gameMult.NumRandom1;
            int numMult2 = gameMult.NumRandom2;
            Console.WriteLine(numMult1 + " * " + numMult2 + " =");
            Console.Write("Your Answer: ");
            int answerMult = int.Parse(Console.ReadLine());
            int multiplication = gameMult.Multiplication();
            if (answerMult != multiplication)
            {
                roundResult = "Multiplication: " + numMult1 + " + " + numMult2 + " = " + multiplication + ". " + "Your Answer: " + answerMult + ". (Wrong)" ;
                Console.WriteLine("Wrong! The correct answer is: " + multiplication);
                Console.WriteLine("");
                Console.WriteLine("______________________________");


            }
            else
            {
                roundResult = "Multiplication: " + numMult1 + " + " + numMult2 + " = " + multiplication + ". " + "Your Answer: " + answerMult + ". (Correct)" ;
                Console.WriteLine("You Got It Right! The answer is: " + multiplication);
                Console.WriteLine("");
                Console.WriteLine("______________________________");


            }
            history.Add(roundResult);
            break;
        case 4:
            Console.WriteLine("Solve the Division: ");
            GameEngine gameDiv = new GameEngine();
            gameDiv.GenerateValidDivisionNumbers();
            int numDiv1 = gameDiv.NumRandom1;
            int numDiv2 = gameDiv.NumRandom2;
            Console.WriteLine(numDiv1 + " / " + numDiv2 + " =");
            Console.Write("Your Answer: ");
            int answerDiv = int.Parse(Console.ReadLine());
            int division = gameDiv.Division();
            if (answerDiv != division)
            {
                roundResult = "Division: " + numDiv1 + " + " + numDiv2 + " = " + division + ". " + "Your Answer: " + answerDiv + ". (Wrong)" ;
                Console.WriteLine("Wrong! The correct answer is: " + division);
                Console.WriteLine("");
                Console.WriteLine("______________________________");
            }
            else
            {
                roundResult = "Division: " + numDiv1 + " + " + numDiv2 + " = " + division + ". " + "Your Answer: " + answerDiv + ". (Correct)" ;
                Console.WriteLine("You Got It Right! The answer is: " + division);
                Console.WriteLine("");
                Console.WriteLine("______________________________");
            }
            history.Add(roundResult);
            break;
        case 5:
            Console.WriteLine("---- Game History ----");
                if (history.Count == 0)
                {
                    Console.WriteLine("Don't have games yet. Play first.");
                }
                else
                {
                    foreach (string games in history)
                    {
                        Console.WriteLine(games);
                    }
                }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();

            break;


    }



} while (choice != 6);

