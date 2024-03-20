public abstract class Goal
{
    public string Name;
    public int Points;
    public string Description;
    public int Score;

    public Goal()
    {
        Console.WriteLine("Enter goal name:");
        Name = Console.ReadLine();
        Console.WriteLine("Enter goal points:");
        Points = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter goal description:");
        Description = Console.ReadLine();
        Score = 0;
    }

    public abstract bool Complete();
    public abstract int MarkComplete();
    public abstract void Display();
}
