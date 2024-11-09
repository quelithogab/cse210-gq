using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int attempts = 0;

            // do-while loop to keep the game running until the correct guess
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {attempts} guesses.");
                }
                
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? ");
            string response = Console.ReadLine().ToLower();

            playAgain = (response == "yes");
        }

        Console.WriteLine("Thank you for playing!");
    }
}
