using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        string defaultFileName = "goals.txt";
        string fileName;

        Console.WriteLine("\nWelcome to the Goal App!");
        Console.WriteLine("Enter filename to create (default: goals.txt):");
        fileName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(fileName))
        {
            fileName = defaultFileName;
        }

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Exit");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    DisplayGoals();
                    break;
                case 3:
                    FileManager.SaveGoalsToFile(fileName, goals);
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case 4:
                    goals = FileManager.LoadGoalsFromFile(fileName);
                    break;
                case 5:
                    RecordGoals();
                    break;
                case 6:
                    FileManager.SaveGoalsToFile(fileName, goals);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    static void DisplayGoals()
    {
        int totalScore = 0;
        Console.WriteLine("Current Goals:\n");
        foreach (Goal goal in goals)
        {
            goal.Display();
            totalScore += goal.Score;
        }
        Console.WriteLine($"Total Score: {totalScore}");
    }

    static void RecordGoals()
    {
        Console.WriteLine("Record Goals:");
        for (var i = 0; i < goals.Count; ++i)
        {
            var goal = goals[i];
            Console.Write((i + 1) + ": ");
            goal.Display();
        }

        Console.WriteLine("Which goal would you like to mark as complete?");
        int selection = int.Parse(Console.ReadLine());

        int pointsEarned = goals[selection - 1].MarkComplete(); // Adjust selection to account for starting index at 1
        Console.WriteLine($"Goal marked as complete. You earned {pointsEarned} points.");

        // Display total points information
        DisplayTotalPoints();
    }

    static void DisplayTotalPoints()
    {
        int totalPoints = 0;
        foreach (Goal goal in goals)
        {
            totalPoints += goal.Points;
        }
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int goalType = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                goals.Add(new SimpleGoal());
                break;
            case 2:
                goals.Add(new Eternal());
                break;
            case 3:
                goals.Add(new Checklist());
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }
}