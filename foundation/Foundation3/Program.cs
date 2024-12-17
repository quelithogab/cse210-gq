using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Local fitness center tracker exercise");
        Console.WriteLine();
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 12, 16), 40, 5.7),
            new Cycling(new DateTime(2024, 12, 17), 50, 35),
            new Swimming(new DateTime(2024, 12, 17), 70, 50),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
