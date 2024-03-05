public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    public void Run()
    {
        Console.Write("\nThis activity will help you relax by guiding you through breathing exercises. Focus on your breath...");
        StartSpinner(5);

        StartActivity();
        while (!AmIDone())
        {
            Console.Write("\nBreathe in...");
            startcountdown(3);
            Console.Write("\nBreathe out...");
            startcountdown(3);
        }
        StartSpinner(5);
        End("breathing");
    }
}