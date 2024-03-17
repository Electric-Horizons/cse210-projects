public class Checklist : Goal
{
    private int bonusPoints;
    private int targetCount;
    private int timesCompleted;

    public Checklist() : base()
    {
        Console.WriteLine("How many times to complete:");
        targetCount = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bonus points:");
        bonusPoints = int.Parse(Console.ReadLine());

        timesCompleted = 0;
    }

    public override bool Complete()
    {
    if (timesCompleted < targetCount)
    {
        timesCompleted++;
        if (timesCompleted == targetCount)
        {
            completedGoalsCount++; // Increment completed goals count
            return true;
        }
    }
    return false;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {Name}, Points: {Points}, Description: {Description}, Checklist Goal");
    }
}
