using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers from the user
        while (true)
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number == 0) break;  // Stop when the user enters 0
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        // Calculate the sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // Find the largest number
        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");

        // Find the smallest positive number
        int? smallestPositive = numbers.Where(n => n > 0).OrderBy(n => n).FirstOrDefault();
        if (smallestPositive.HasValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        // Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
