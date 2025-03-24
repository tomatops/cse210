using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

// Stores a list of journal entries
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Stores an entry to a list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays all journal entries stored in a list
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("--------------------");
            entry.Display();  
        }
    }

    // Saves all journal entries to a file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
            outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    // Loads file into the journal
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Entry writeEntry = new Entry();
            writeEntry._date = date;
            writeEntry._promptText = prompt;
            writeEntry._entryText = entry;

            _entries.Add(writeEntry);
        } 
    }
}