using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();

        int gradePercentage = int.Parse(userInput);

        // Initialize the letter variable
        char letter;

        // Determine the letter grade based on the percentage
        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        // Display the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        // Check if the user passed the course and display a message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Encourage for next time. Keep trying!");
        }
    }
}

