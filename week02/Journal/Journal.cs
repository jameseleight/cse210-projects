using System;
using System.IO;
using System.IO.Enumeration;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        // Declare DateTime class and generate date string in format of mm/dd/yyyy
        DateTime now = DateTime.Now;
        string todaydate = now.ToString("d");

        // Declare PromptGenerator class and allocate varaible
        PromptGenerator prompt2 = new PromptGenerator();
        // Generate jounal prompt question as a string
        string question = prompt2.GetRandomPrompt();

        // Write the date and question to the console and then read the answer response
        Console.WriteLine($"Date: {todaydate}");
        Console.WriteLine($"Question: {question}");
        Console.Write($"Response: ");
        string response = Console.ReadLine();
        Console.WriteLine();

        // Declare Entry class and set attributes of entry variable to values collected above
        Entry entry1 = new Entry();
        entry1._date = todaydate;
        entry1._promptText = question;
        entry1._entryText = response;

        // Add entry to journal list
        _entries.Add(entry1);
    }
    public void DisplayAll()
    {
        Console.WriteLine("The Journal entries are the following:");
        Console.WriteLine();
        foreach (Entry entryitem in _entries)
        {
            entryitem.Display();
        }
    }
    public void SaveToFile()
    {
        string journalFileName = "";
        Console.Write($"Enter a new filename to save the journal (hit enter for default = MyJournal.txt) ");
        string answer = Console.ReadLine();
        if (answer == "")
        {
            journalFileName = "MyJournal.txt";
        }
        else
        {
            journalFileName = answer;
        }
        using (StreamWriter outputFile = new StreamWriter(journalFileName))
        {
            foreach (Entry entryitem in _entries)
            {
                outputFile.WriteLine(entryitem._date);
                outputFile.WriteLine(entryitem._promptText);
                outputFile.WriteLine(entryitem._entryText);
                outputFile.WriteLine();
            }
        }
        Console.WriteLine($"The Journal was written to {journalFileName}.");
        Console.WriteLine();
    }
    public void LoadFromFile()
    {
        // Declare Entry class and set attributes of entry variable to values collected above
        string fileName = "";
        int index = 0;
        Console.Write("Enter a filename to load (hit Enter for default = MyJournal.txt) ");
        string answer = Console.ReadLine();
        if (answer == "")
        {
            fileName = "MyJournal.txt";
        }
        else
        {
            fileName = answer;
        }
        Entry entry1 = new Entry();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            if (index == 0)
            {
                entry1._date = line;
                index++;
            }
            else if (index == 1)
            {
                entry1._promptText = line;
                index++;
            }
            else if (index == 2)
            {
                entry1._entryText = line;
                index++;
            }
            else // index == 3 and the line is a blank
            {
                entry1.Display();
                _entries.Add(entry1);
                index = 0;
                entry1 = new Entry();
                foreach (Entry entryitem in _entries)
                {
                    entryitem.Display();
                }
            }
        }
        Console.WriteLine($"The Journal was read from {fileName}.");
        Console.WriteLine();
    }
}