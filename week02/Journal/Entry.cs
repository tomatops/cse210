using System;

// Represents a single journal entry.
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // Displays a single entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}