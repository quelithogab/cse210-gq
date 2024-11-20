using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Constructor 1
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString()); // Output: 1/1
        Console.WriteLine(fraction1.GetDecimalValue());  // Output: 1

        // Test Constructor 2
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString()); // Output: 5/1
        Console.WriteLine(fraction2.GetDecimalValue());  // Output: 5

        // Test Constructor 3
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString()); // Output: 3/4
        Console.WriteLine(fraction3.GetDecimalValue());  // Output: 0.75

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString()); // Output: 1/3
        Console.WriteLine(fraction4.GetDecimalValue());  // Output: 0.333...

        // Test Getters and Setters
        fraction4.SetTop(3);
        fraction4.SetBottom(5);
        Console.WriteLine(fraction4.GetFractionString()); // Output: 3/5
        Console.WriteLine(fraction4.GetDecimalValue());  // Output: 0.6
    }
}