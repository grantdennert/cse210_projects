using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Today.ToShortDateString();
        PromptGenerator prompt = new PromptGenerator();
        newEntry._prompt = prompt.GeneratePrompt();
        Console.WriteLine(newEntry._prompt);
        newEntry._response = Console.ReadLine();

        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();
        using (StreamWriter writeFile= new StreamWriter(fileName))
        
        {
            foreach (Entry entry in _entries)
            {
                writeFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }   
        }
        Console.WriteLine("Saving...");
    }
    public void LoadFromFile()
    {
        Console.WriteLine("What is the file name? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry readEntry = new Entry();
            string[] parts = line.Split("|");
            readEntry._date = parts[0];
            readEntry._prompt = parts[1];
            readEntry._response = parts[2];
            _entries.Add(readEntry);
        }
    }
}