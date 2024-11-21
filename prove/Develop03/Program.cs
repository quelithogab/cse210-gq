using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // A library of scriptures
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not on thine own understanding.\nIn all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that He gave His only begotten Son,\nthat whosoever believeth in Him should not perish, but have everlasting life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Psalm", 23, 1, 2), "The Lord is my shepherd, I shall not want.\nHe maketh me to lie down in green pastures: he leadeth me beside the still waters.")
        };

        // Select a random scripture from the library
        var random = new Random();
        Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("Memorize the scripture presented below. You can type 'hint' for help or 'quit' to exit.\n");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Press Enter to hide words.");
            Console.WriteLine("2. Type 'hint' for help.");
            Console.WriteLine("3. Type 'quit' to exit.");
            Console.Write("\nYour choice: ");

            string input = Console.ReadLine()?.ToLower();

            if (input == "quit" || selectedScripture.IsCompletelyHidden())
            {
                break;
            }
            else if (input == "hint")
            {
                ShowHint(selectedScripture);
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
            else
            {
                selectedScripture.HideRandomWords(3); // Hide 3 random words
            }
        }

        Console.WriteLine("\nThank you for using the Scripture Memorization Program!\nGoodbye!");
    }

    // Displays a hint by revealing the first letter of each hidden word
    static void ShowHint(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine("Hint: The first letter of each hidden word is shown below.");
        Console.WriteLine(scripture.GetHintDisplayText());
    }
}

/*
 * EXCEEDING REQUIREMENTS REPORT:
 * 1.- The program now works with a library of scriptures instead of a single one. A scripture is randomly selected
 *    for the user at the start of the program. This enhances variety and keeps the experience fresh.
 * 2.- A hint system has been added. When the user types "hint," the program displays the first letter of all hidden
 *    words to aid memorization without fully revealing the words. This feature provides a more interactive and helpful
 *    learning experience.
 */
