using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public void CreateFile(string fileName)
    {
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        if (File.Exists(fileName))
        {
            Console.WriteLine("File already exists. Overwrite? (y/n)");
            string overwrite = Console.ReadLine();
            if (overwrite.ToLower() != "y")
            {
                Console.WriteLine("File creation aborted.");
                return;
            }
        }

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Journal File Created");
            writer.WriteLine($"Created on: {DateTime.Now}");
            writer.WriteLine();
        }

        Console.WriteLine($"File '{fileName}' created successfully.");
    }

    public void LoadFile(string fileName, List<(string prompt, string entry, DateTime dateTime)> entries)
    {
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            string prompt = null;
            string entry = null;
            DateTime dateTime = DateTime.MinValue;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date: "))
                {
                    dateTime = DateTime.Parse(line.Substring(6));
                }
                else if (line.StartsWith("Prompt: "))
                {
                    prompt = line.Substring(8);
                }
                else if (line.StartsWith("Entry: "))
                {
                    entry = line.Substring(7);
                }
                else if (string.IsNullOrWhiteSpace(line))
                {
                    if (prompt != null && entry != null)
                    {
                        entries.Add((prompt, entry, dateTime));
                        prompt = null;
                        entry = null;
                        dateTime = DateTime.MinValue;
                    }
                }
            }
        }

        Console.WriteLine($"File '{fileName}' loaded successfully.");
    }

    public void SaveFile(string fileName, List<(string prompt, string entry, DateTime dateTime)> entries)
    {
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date: {entry.dateTime}");
                writer.WriteLine($"Prompt: {entry.prompt}");
                writer.WriteLine($"Entry: {entry.entry}");
                writer.WriteLine();
            }
        }

        Console.WriteLine($"Entries saved to file '{fileName}'.");
    }

    public void DisplayJournal(string fileName)
    {
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        Console.WriteLine($"Journal from file '{fileName}' displayed successfully.");
    }
}
