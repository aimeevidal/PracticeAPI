using System;

namespace APIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            appIntro();
            greetPlayer();

            while (true)
            {
                Random randomNum = new Random();

                int correctNum = randomNum.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Enter a number:");

                while (guess != correctNum)
                {


                    string userInput = Console.ReadLine();

                    if (!int.TryParse(userInput, out guess))
                    {
                        //Console.WriteLine("Not a number. Enter an actual number");
                        printColoredMessages(ConsoleColor.Red, "Not a number. Enter an actual number");
                        continue;
                    }

                    guess = Int32.Parse(userInput);

                    if (guess != correctNum)
                    {
                        printColoredMessages(ConsoleColor.Red, "Wrong! Try again.");
                    }

                }

                printColoredMessages(ConsoleColor.Yellow, "CORRECT!");

                Console.WriteLine("Do you want to play again? [Y or N]");

                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain == "Y")
                {
                    continue;
                }

                else if (playAgain == "N")
                {
                    printColoredMessages(ConsoleColor.Red, "Okay, BYE!");
                    return;
                }

                else
                {
                    return;
                }

            }
        }

        static void appIntro()
        {
            string appName = "Piper's Guess the Number App";
            string appVersion = "1.0.0";
            string appAuthor = "Piper";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to {0} by {1}. version {2}", appName, appAuthor, appVersion);
            Console.ResetColor();
        }

        static void greetPlayer()
        {
            Console.WriteLine("What's your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine("Hi {0}. Let's play a game. Guess the correct number.", playerName);
        }

        static void printColoredMessages(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
