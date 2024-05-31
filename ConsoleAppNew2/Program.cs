using System;

namespace ConsoleAppNew2
{
    class Program
    
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 3
            int correctNumber = new Random().Next(1, 4);

            Console.WriteLine("Guess the number between 1 and 3:");

            // Read the user's guess from the console
            int guessedNumber = int.Parse(Console.ReadLine());

            // Check if the guessed number is within the valid range
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside the valid range.");
            }
            else
            {
                // Check if the guessed number matches the correct number
                if (guessedNumber == correctNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                }
                else
                {
                    // Provide feedback based on whether the guess is higher or lower than the correct number
                    if (guessedNumber < correctNumber)
                    {
                        Console.WriteLine("Your guess is too low.");
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too high.");
                    }
                }
            }
        }
    }
}