using System;
using System.Collections.Generic;

public class Program
{
    // Log dictionary to keep track of activity counts
    private static Dictionary<string, int> activityLog = new Dictionary<string, int>();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Additional Activity");
            Console.WriteLine("5. Show Activity Log");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                RunActivity(breathingActivity);
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                RunActivity(reflectingActivity);
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                RunActivity(listingActivity);
            }
            else if (choice == "4")
            {
                AdditionalActivity additionalActivity = new AdditionalActivity();
                RunActivity(additionalActivity);
            }
            else if (choice == "5")
            {
                DisplayActivityLog();
            }
            else if (choice == "6")
            {
                Console.WriteLine();
                Console.WriteLine("You did a good job today!");
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);
            }
        }
    }

    private static void RunActivity(Activity activity)
    {
        // Cast the activity to its specific type and call its Run method
        if (activity is BreathingActivity breathingActivity)
        {
            breathingActivity.Run();
        }
        else if (activity is ReflectingActivity reflectingActivity)
        {
            reflectingActivity.Run();
        }
        else if (activity is ListingActivity listingActivity)
        {
            listingActivity.Run();
        }
        else if (activity is AdditionalActivity additionalActivity)
        {
            additionalActivity.Run();
        }

        // Update the log
        if (activityLog.ContainsKey(activity.GetType().Name))
        {
            activityLog[activity.GetType().Name]++;
        }
        else
        {
            activityLog[activity.GetType().Name] = 1;
        }
    }

    private static void DisplayActivityLog()
    {
        Console.WriteLine("\nActivity Log:");
        foreach (var entry in activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}

// Showing Creativity and Exceeding Requirements:
// - Added an AdditionalActivity class for creative visualization.
// - Implemented a logging mechanism to keep track of how many times each activity is performed.
// - Provided a menu option to display the activity log.
