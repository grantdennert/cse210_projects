using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string response = "yes";
        int guess;
        int guessCounter;
        do
        {
            int magicNumber = randomGenerator.Next(1,100);
            guessCounter = 0;
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCounter ++;
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Total guesses: {guessCounter}");
                }
            } while (guess != magicNumber);
            Console.WriteLine("Do you want to continue?");
            response = Console.ReadLine();
        } while (response == "yes");
        Console.WriteLine("Goodbye!");
    }
}