// Journal.cs
// Manages a collection of journal entries and handles file operations.

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
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    // Saves the journal entries to a file in CSV format with headers and handling of commas and quotes
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("Date,Prompt,Mood,EntryText"); // Header for CSV
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{entry._mood}\",\"{entry._entryText}\"");
            }
        }
        Console.WriteLine($"Journal saved to {file}");
    }

    // Loads journal entries from a file
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            for (int i = 1; i < lines.Length; i++) // Skips the header
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length == 4)
                {
                    string date = parts[0].Trim('"');
                    string prompt = parts[1].Trim('"');
                    string mood = parts[2].Trim('"');
                    string entryText = parts[3].Trim('"');
                    Entry entry = new Entry(date, prompt, entryText, mood);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine($"Journal loaded from {file}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
