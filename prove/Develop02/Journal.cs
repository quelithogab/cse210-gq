using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Adds a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays all entries in the journal
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    // Saves all entries to a specified file in CSV format
    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                // Format: Date,Prompt,EntryText,Mood
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText},{entry._mood}");
            }
        }
        Console.WriteLine($"Journal saved to {fileName}");
    }

    // Loads entries from a specified file in CSV format
    public void LoadFromFile(string fileName)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 4)  // Ensure we have all parts (Date, Prompt, EntryText, Mood)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2],
                        _mood = parts[3]
                    };
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine($"Journal loaded from {fileName}");
    }
}
