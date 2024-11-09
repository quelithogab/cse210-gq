using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string user = Console.ReadLine();
        int grade = int.Parse(user);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "A" && letter == "F" )
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade < 97)
        {
            int lastDigit = grade % 10;
            if (lastDigit < 3)
            {
                sign = "-";
            }
            
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Good job, You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}