public class SimpleGoal : Goal
{
    bool completed;

    public SimpleGoal() : base()
    {
        completed = false;
    }

    public override int MarkComplete()
    {
        if (!completed)
        {
            completed = true;
            Score += Points; // Increment score by points when completed
            return Points;
        }
        return 0;
    }

    public override bool Complete()
    {
        return completed;
    }

    public override void Display()
    {
        var done = Complete() ? "X" : " ";
        Console.WriteLine($"[{done}] {Name}, {Points}, ({Description}), Simple Goal");
    }
}