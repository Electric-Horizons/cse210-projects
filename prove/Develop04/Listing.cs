public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
        
    public ListingActivity(int duration) : base(duration) { }

    public override void Run()
    {
        Start();
        Console.WriteLine("This activity will help you reflect on the good things in your life by listing as many things as you can.");
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("Start listing...");
        Thread.Sleep(duration * 1000); // Wait for the specified duration
        Console.WriteLine("End listing...");
        End("listing");
    }
}