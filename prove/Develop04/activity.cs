public abstract class MindfulnessActivity
{
    protected int duration;

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    // Common starting message
    public virtual void Start()
    {
        Console.WriteLine("Get ready to start...");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    // Common ending message
    public virtual void End(string name)
    {
        Console.WriteLine($"Well done! You have completed the {name} activity for {duration} seconds.");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    // Method to display spinner animation during pauses
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". "); // Simple spinner animation
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    // Method to run the activity
    public abstract void Run();
}

// Breathing Activity class
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Run()
    {
        Start();
        Console.WriteLine("This activity will help you relax by guiding you through breathing exercises. Focus on your breath...");
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
        }
        End("breathing");
    }
}

// Reflection Activity class
public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
}