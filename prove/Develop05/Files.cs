public static class FileManager
{
    public static void SaveGoalsToFile(string fileName, List<Goal> goals)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                {
                    if (goal is SimpleGoal simpleGoal)
                    {
                        writer.WriteLine($"SimpleGoal,{simpleGoal.Name},{simpleGoal.Points},{simpleGoal.Description}");
                    }
                    else if (goal is Eternal eternalGoal)
                    {
                        writer.WriteLine($"Eternal,{eternalGoal.Name},{eternalGoal.Points},{eternalGoal.Description}");
                    }
                    else if (goal is Checklist checklistGoal)
                    {
                        writer.WriteLine($"Checklist,{checklistGoal.Name},{checklistGoal.Points},{checklistGoal.Description}");
                    }
                }
            }
            Console.WriteLine("Goals saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving goals to file: " + ex.Message);
        }
    }

    public static List<Goal> LoadGoalsFromFile(string fileName)
    {
        List<Goal> loadedGoals = new List<Goal>();
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 4)
                {
                    string type = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);
                    string description = parts[3];

                    switch (type)
                    {
                        case "SimpleGoal":
                            loadedGoals.Add(new SimpleGoal(name, points, description));
                            break;
                        case "Eternal":
                            loadedGoals.Add(new Eternal(name, points, description));
                            break;
                        case "Checklist":
                            loadedGoals.Add(new Checklist(name, points, description));
                            break;
                        default:
                            Console.WriteLine($"Unknown goal type '{type}' found in file.");
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("No existing goals file found.");
        }
        return loadedGoals;
    }
}