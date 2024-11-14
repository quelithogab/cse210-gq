using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Get a category-specific prompt
                    Console.WriteLine("\nChoose a prompt category:");
                    Console.WriteLine("1. Reflection");
                    Console.WriteLine("2. Gratitude");
                    Console.WriteLine("3. Planning");
                    Console.Write("Select a category (1-3): ");
                    string categoryChoice = Console.ReadLine();
                    string prompt = promptGenerator.GetRandomPrompt(categoryChoice);

                    // Ask for mood tracking
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Enter your mood (e.g., Happy, Sad, Anxious): ");
                    string mood = Console.ReadLine();

                    // Add entry
                    Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response, mood);
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter file name to save (e.g., journal.csv): ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case "4":
                    Console.Write("Enter file name to load (e.g., journal.csv): ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
                case "5":
                    Console.Write("Thanks for adding something to the journal. Bye!");
                    running = false;
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
