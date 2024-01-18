using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int countGuess = 0;

        Console.WriteLine("Guess the number!");

        while (guess != magicNumber)
        {
            //  Ask for user guess
            System.Console.Write("Guess a number: ");
            guess = int.Parse(Console.ReadLine());
            countGuess++;
            //  Check if the guess is higher
            if (guess > magicNumber)
            {
                System.Console.WriteLine("Too High");
            }
            //  Check if the guess is lower
            else if (guess < magicNumber)
            {
                System.Console.WriteLine("Too Low for the limb");
            }
            //  Check if the guess is a match
            else
            {
                System.Console.WriteLine("Correct");
            }
        }
        Console.WriteLine($"It took you {countGuess} attempts to get the number.");
    }
}