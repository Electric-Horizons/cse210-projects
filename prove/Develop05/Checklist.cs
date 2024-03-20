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

    public override int MarkComplete()
    {
        if (timesCompleted < targetCount)
        {
            timesCompleted++;
            if (timesCompleted == targetCount)
            {
                Score += (Points + bonusPoints); // Increment score by points + bonus when completed
                return Points + bonusPoints;
            }
            else
            {
                Score += Points; // Increment score by points
                return Points;
            }
        }
        return 0;
    }

    public override bool Complete()
    {
        return timesCompleted == targetCount;
    }

    public override void Display()
    {
        var done = Complete() ? "X" : " ";
        Console.WriteLine($"[{done}] {Name}, {Points}, ({Description}), Checklist Goal ({timesCompleted}/{targetCount} done)");
    }
}            