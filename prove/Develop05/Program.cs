using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static string fileName = "goals.txt";
    private static int completedGoalsCount = 0;

    public abstract bool Complete();


    static void Main(string[] args)
    {
        LoadGoalsFromFile();

        while (true)
        {
            Console.WriteLine("Welcome to the Goal App!");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Record Goals"); // Assuming Record Goals is a separate feature
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("7. Exit");

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
                    RecordGoals();
                    break;
                case 4:
                    LoadGoalsFromFile();
                    break;
                case 5:
                    FileManager.SaveGoalsToFile(fileName, goals);
                    Console.WriteLine("Goals saved successfully.");
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

    static void LoadGoalsFromFile()
    {
        try
        {
            goals = FileManager.LoadGoalsFromFile(fileName);
            Console.WriteLine("Goals loaded from file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading goals from file: " + ex.Message);
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (Goal goal in goals)
        {
            goal.Display();
        }
    }

    static void GoalCreation()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int goalType = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                CreateSimpleGoal();
                goals.Add(new SimpleGoal());
                break;
            case 2:
                CreateEternalGoal();
                goals.Add(new EternalGoal());
                break;
            case 3:
                CreateChecklistGoal();
                goals.Add(new ChecklistGoal());
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }
}