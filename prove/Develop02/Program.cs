using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Create a new entry
                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToString("yyyy-MM-dd"),
                        _promptText = promptGenerator.GetRandomPrompt()
                    };
                    
                    Console.WriteLine("Prompt: " + entry._promptText);
                    Console.Write("Your response: ");
                    entry._entryText = Console.ReadLine();

                    Console.Write("Your mood (e.g., Happy, Sad, Anxious):");
                    entry._mood = Console.ReadLine();

                    myJournal.AddEntry(entry);
                    Console.WriteLine("Entry added.\n");
                    break;

                case "2":
                    // Display all entries
                    Console.WriteLine("Displaying all entries:");
                    myJournal.DisplayAll();
                    break;

                case "3":
                    // Save journal to file
                    Console.Write("Enter file name to save (e.g., journal.csv): ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    break;

                case "4":
                    // Load journal from file
                    Console.Write("Enter file name to load (e.g., journal.csv): ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    break;

                case "5":
                    // Exit
                    running = false;
                    Console.WriteLine("Thanks for adding something to the journal. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}


// Exceeded requirements that added:
// - Added mood tracking feature to each entry.
// - Added specific prompt categories for improved user experience.
// - Improved file saving format by using CSV, compatible with spreadsheet applications.
// - Added a thank you message at the end.
// - Proper handling of quotes and commas in saved CSV entries.
