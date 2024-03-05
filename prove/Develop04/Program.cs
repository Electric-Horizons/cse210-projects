using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 4)
            {
                exit = true;
                continue; // Skip to the next iteration of the loop
            }

            Console.WriteLine("Enter duration (in seconds):");
            int duration = int.Parse(Console.ReadLine());

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);

            switch (choice)
            {
                case 1:
                    {
                        var activity = new BreathingActivity(duration);
                        activity.Run();
                        break;
                    }
                case 2:
                    {
                        var activity = new ReflectionActivity(duration);
                        activity.Run();
                        break;
                    }
                case 3:
                    {
                        var activity = new ListingActivity(duration);
                        activity.Run();
                        break;
                    }
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}