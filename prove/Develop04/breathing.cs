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