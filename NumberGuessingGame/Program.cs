using System;

class NumberGuessingGame
{
    static void Main(String[] args)
    {
        Random rand = new Random();
        int randomNumber = rand.Next(1, 100000000);
        int guess;
        int numberOfGuesses = 0;
        bool continueGame = true;

        Console.WriteLine(@"Welcome to the Number Guessing Game.
The rules are simple: try to guess the number
If you guess too low, the game will let you know
If you guess too high, the game will let you know.
WARNING: THIS GAME CONTAINS ROASTS THAT HAPPEN EVERY 10 ATTEMPTS!");


        while (continueGame)
        {
            Console.WriteLine("Enter a guess");
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < randomNumber)
                {
                    Console.WriteLine("You've guessed low!");
                    numberOfGuesses++;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("You've guessed high");
                    numberOfGuesses++;
                }
                else
                {
                    Console.WriteLine("You've guessed correct!");
                    continueGame = false;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input out of range! Please enter a number between 1 and 100000000");
            }
            if (numberOfGuesses == 101)
            {
                Console.WriteLine("You are so bad at counting numbers that you lost the game! Better luck next time!");
                continueGame = false;
            }
            else if (numberOfGuesses == 100)
            {
                Console.WriteLine("I've heard of beginners luck, but this is just sad.");
            }
            else if (numberOfGuesses == 90)
            {
                Console.WriteLine("I'm not saying you're bad at guessing, but even a broken clock is right twice a day.");
            }
            else if (numberOfGuesses == 80)
            {
                Console.WriteLine("I'm surprised you even made it this far in life with guessing skills like that.");
            }
            else if (numberOfGuesses == 70)
            {
                Console.WriteLine("You're so bad at guessing, you should consider a career in politics.");
            }
            else if (numberOfGuesses == 60)
            {
                Console.WriteLine("I'm starting to think you're purposely trying to lose.");
            }
            else if (numberOfGuesses == 50)
            {
                Console.WriteLine("I thought this was a number guessing game, not a number guessing disaster.");
            }
            else if (numberOfGuesses == 40)
            {
                Console.WriteLine("You're making this game too easy for me.");
            }
            else if (numberOfGuesses == 30)
            {
                Console.WriteLine("I've seen rocks with better guessing skills.");
            }
            else if (numberOfGuesses == 20)
            {
                Console.WriteLine("Wow, you really don't know how to count, do you?");
            }
            else if (numberOfGuesses == 10)
            {
                Console.WriteLine("I guess math wasn't your strong suit.");
            }
        }

    }
}