using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 8; i++)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
    }
}
