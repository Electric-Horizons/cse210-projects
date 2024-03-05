public class MindfulnessActivity
{
    protected int duration;
    protected DateTime futureTime;

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    protected void StartActivity()
    {
        DateTime startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(duration);
    }

    protected bool AmIDone()
    {
        return DateTime.Now > futureTime;
    }

    // Common starting message

    protected void startcountdown(int duration)
    {
        while (duration >= 0)
        {
            Console.Write($"{duration--}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void StartSpinner(int duration)
    {
        Console.WriteLine("Get ready to start...");
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        int i = 0;

        while (DateTime.Now < futureTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
            // Thread.Sleep(2000); // Pause for 2 seconds
        }
    }
    // {
    //     Console.WriteLine("Get ready to start...");
    //     List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

    //     int i = 0;

    //     while (DateTime.Now < futureTime)
    //     {
    //         string s = animationStrings[i];
    //         Console.Write(s);
    //         Thread.Sleep(100);
    //         Console.Write("\b   \b");

    //         i = (i + 1) % animationStrings.Count;
    //     }
    // }

    // Common ending message
    public void End(string name)
    {
        Console.WriteLine($"\n\nWell done! You have completed the {name} activity for {duration} seconds.");
        StartSpinner(5);
    }
}