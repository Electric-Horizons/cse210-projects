using System;

class Program 
{
    static public Journal journal;

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Hello Develop02 World!");
        Run();
    }

    static public string GetPrompt()
    {
        // Get a randomized list of entries
        var randomizedEntries = journal.Entries.OrderBy(x => Guid.NewGuid()).ToList();

        // Present the entries to the user
        foreach (var entry in randomizedEntries)
        {
            entry.Display(); // Call the Entry class's Display method
            Console.WriteLine("---------------------------");
        }
        
        // generate's through Random prompts
        // pulls up random prompt
        return "";
    }

    static public void Run()
    {
        Entry entry = new Entry(); 
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.clear();
            var selection = ShowMenu();

            if (selection == 1)
            {
                //Prompt user with a random prompt
                var prompt = "This was a random prompt";
                //Read in user input
                Console.WriteLine("Enter your response: ");
                var response = Console.ReadLine();
                // var placeholderResponse = "This was what the user typed in";

                var entry = new Entry(response, prompt);
                journal.AddEntry(entry);
            }
            else if (selection == 2)
            {
                //display entries
                Console.Clear();
                entry.DisplayEntry();
            }
            //  selection == 3
            // Save File
            else if (choice == 3) //Save entry
            {
                var lines = entry.Export();
                WriteFile(lines);
            }
            // selection == 4
            // Load File
            else if (choice == 4) //Load entry
            {
                var lines = ReadFile();
                dealer = new Dealer(lines);
            }
            else if (selection == 5)
            {
                keepGoing = false;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Journal");
        Console.WriteLine("---------------------");
        Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entries \n 3. Save Entry \n 4. Load Entry \n 5. Exit \n");

        Console.Write("\nEnter your choice: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    static public void SaveToFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }

    static public void LoadFromFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }
}