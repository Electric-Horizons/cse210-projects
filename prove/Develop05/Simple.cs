public class SimpleGoal : Goal
{
    bool completed;

    public SimpleGoal() : base()
    {
        completed = false;
    }

    public override int MarkComplete()
    {
        if (completed) {
            return 0;
        }
        completed = true;
        return Points;
    }

    public override bool Complete()
{
    if (!completed)
    {
        completed = true;
        completedGoalsCount++; // Increment completed goals count
        return true;
    }
    return false; // Goal already completed
}

    public override void Display()
    {
        Console.WriteLine($"Name: {Name}, Points: {Points}, Description: {Description}, Completed: {completed}");
    }
}