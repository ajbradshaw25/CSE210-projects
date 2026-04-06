using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create one of each activity type
        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new Cycling("04 Nov 2022", 45, 12.5));
        activities.Add(new Swimming("05 Nov 2022", 20, 20));

        // Iterate and display summaries
        Console.WriteLine("Fitness Center Activity Log:");
        Console.WriteLine("--------------------------------------------------");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("--------------------------------------------------");
    }
}
