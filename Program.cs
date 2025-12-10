using System;

namespace Guessing
{
    class GameLogic
    {
        public static bool CheckVal(int checkVal, int input)
        {
            if (input < 0)
            {
                Console.WriteLine("Can't be less then 0");
                return false;
            }
            else if (input > 100)
            {
                Console.WriteLine("Can't be greater then 100");
                return false;
            }
            else if (input > checkVal)
            {
                Console.WriteLine("You're guess is larger then the answer");
                return false;
            }
            else if (input < checkVal)
            {
                Console.WriteLine("You're guess is less then the answer");
                return false;
            }
            else
            {
                Console.WriteLine("You've guessed correctly!");
                return true;
            }
        }
        class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to number guesser!\n\n");


                Random rand = new();
                int target = rand.Next(0, 101);
                int guessCount = 0;

                bool guessed = false;

                while (!guessed)
                {
                    Console.WriteLine("Please enter a number from 0 to 100");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int guess))
                    {
                        guessed = CheckVal(target, guess);
                        guessCount++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input type");
                    }
                }

                Console.WriteLine(string.Format("It took you {0} number of guesses to get it correct!", guessCount));
            }
        }

    }
}