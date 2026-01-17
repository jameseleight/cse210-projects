using System;
public class Journal
{
    public List<Entry> _journal = new List<Entry>();
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
        _journal.Add(entry1);
    }

    public void DisplayAll()
    {
        Console.WriteLine("The Journal entries are the following:");
        Console.WriteLine();
        foreach (Entry entryitem in _journal)
        {
            entryitem.Display();
        }
    }
}