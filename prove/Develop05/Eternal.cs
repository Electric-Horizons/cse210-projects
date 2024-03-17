public class Eternal : Goal
{
    public Eternal() : base()
    {

    }

    public override int MarkComplete()
    {
        return Points;
    }

    public override bool Complete()
    {
        // Eternal goals cannot be completed
        return false;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {Name}, Points: {Points}, Description: {Description}, Eternal Goal");
    }
}