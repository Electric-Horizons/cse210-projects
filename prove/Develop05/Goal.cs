public abstract class Goal
{
    public string Name;
    public int Points;
    public string Description;

    public CreateGoal()
    {
        Console.WriteLine("Enter goal name:");
        Name = Console.ReadLine();
        Console.WriteLine("Enter goal points:");
        Points = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter goal description:");
        Description = Console.ReadLine();
    }

    public abstract bool Complete();
    //public abstract int Complete();

    public abstract bool MarkComplete();
    //public abstract int MarkComplete();
    public abstract void Display();
}
