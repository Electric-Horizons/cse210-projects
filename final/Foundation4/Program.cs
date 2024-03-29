using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities of each type
        RunningActivity running = new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0);
        CyclingActivity cycling = new CyclingActivity(new DateTime(2022, 11, 3), 30, 20);
        SwimmingActivity swimming = new SwimmingActivity(new DateTime(2022, 11, 3), 30, 20);

        // Put each activity in the same list
        List<Activity> activities = new List<Activity>
        {
            running,
            cycling,
            swimming
        };

        // Display summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}