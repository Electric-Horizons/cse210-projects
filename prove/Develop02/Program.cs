namespace dev02;

using System;

class Program 
{
    // public static Journal journal;

    static void Main(string[] args)
    {
        var e = new Entry("lkjsdf", "laksjdf", "lskjdf");
        Console.WriteLine("Hello Develop02 World!");
        Run();
    }

    

    public static void Run()
    {
        Journal journal = new Journal();
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.Clear();
            var selection = ShowMenu();

            if (selection == 1)
            {
                journal.AddEntry();
            }
            else if (selection == 2)
            {
                //display entries
                Console.Clear();
                journal.Display();
            }
            //  selection == 3
            // Save File
            else if (selection == 3) //Save entry
            {
                var lines = journal.Export();
                SaveToFile(lines);
            }
            // selection == 4
            // Load File
            else if (selection == 4) //Load entry
            {
                var lines = LoadFromFile();
                journal = new Journal(lines);
            }
            else if (selection == 5)
            {
                keepGoing = false;
            }
            else
            {
                Console.WriteLine("Invalid selection");
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

    public static void SaveToFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }

    public static string[] LoadFromFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }
}

// Emma, I worked with Brother Lynn on this for a while and we could not get the journal class to run on its own, it seems to be broken somehow
// if you have any ideas on how to fix it, please let me know, Brother Lynn said this should be fine for now as long as everything else works,
// thanks!

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public Journal(string[] importLines)
    {
        entries = new List<Entry>();
        foreach (var line in importLines)
        {
            var entry = new Entry(line);
            entries.Add(entry);
        }
    }

    public void AddEntry()
    {
        var prompt = Entry.GetPrompt();
        // have them write in the entry.
        Console.WriteLine(prompt); 
        Console.Write("Enter response: ");
        var response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

        var entry = new Entry(prompt, response, date);

        entries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine("\nEntry List:");
        Console.WriteLine("---------");

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.DisplayString());
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var entry in entries)
        {
            var exportString = entry.Export();
            exportLines.Add(exportString);
        }
        return exportLines.ToArray();
    }
}