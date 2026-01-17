using System;
public class Entry
{
    public string _promptText;
    public string _entryText;
    public string _date;
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Question: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine();
    }
}