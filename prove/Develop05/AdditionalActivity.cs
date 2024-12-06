using System;

public class AdditionalActivity : Activity
{
    public AdditionalActivity() : base("Additional Activity", "This activity is a unique addition that involves creative thinking and visualization.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nImagine a peaceful place that brings you joy. Visualize it in your mind with as much detail as possible...");
        ShowSpinner(_duration);
        DisplayEndingMessage();
    }
}
