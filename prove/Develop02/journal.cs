using System;
using System.Collections.Generic;

public class Journal
{
    private List<(string prompt, string entry, DateTime dateTime)> entries = new List<(string, string, DateTime)>();
    private Prompts newPrompt = new Prompts();
    private Entry entryManager = new Entry();

    public Journal()
    {
        newPrompt.popPrompts(); // Ensure the prompts list is populated
    }

    public void GetPromptAndEntry()
    {
        string prompt = newPrompt.randomPrompt();
        Console.WriteLine(prompt);
        string entry = Console.ReadLine();
        DateTime dateTime = DateTime.Now;
        entries.Add((prompt, entry, dateTime));
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.dateTime}");
            Console.WriteLine($"Prompt: {entry.prompt}");
            Console.WriteLine($"Entry: {entry.entry}");
            Console.WriteLine();
        }
    }

    public void LoadJournal(string fileName)
    {
        entries.Clear(); // Clear current entries
        entryManager.LoadFile(fileName, entries); // Load entries from file
    }

    public void SaveJournal(string fileName)
    {
        entryManager.SaveFile(fileName, entries);
    }

    public void CreateJournal(string fileName)
    {
        entryManager.CreateFile(fileName);
    }
}
