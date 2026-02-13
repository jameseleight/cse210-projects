using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
// This class includes a method to create a bool list of the specified value to mark which prompts or questions have been unused.
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }
    public void DisplayStartingMessage()
    {
        // display to the console the _name of the activity and the _description
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        // display and collect input on the console for the duration of the activity
        Console.Write("How long, in seconds, would you like to do this activity? ");
        _duration = int.Parse(Console.ReadLine());
        // display preparation message and show spinner for some short duration
        Console.Clear();
        Console.Write("Get ready ... ");
        ShowSpinner(2);
        Console.WriteLine();
    }
    public void DisplayEndingMessage(int total)
    {
        // display to the console the message that tells the user they did a good job, pause, display to the console
        //  the name of the activity and the length of time.  Then finish/done.
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed a total of {total} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        // run the spinner annimation for the specified duration in seconds
        // define the spinner annimation strings/symbols
        List<string> animationStrings = ["|", "/", "-", "\\"];
        // set up start and end times to run duraiton of the animation
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        // run the loop
        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        // display a countdown 1 second at a time for the specified duration in seconds
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public List<bool> CreateBoolList(int count, bool setingValue)
    {
        // display a countdown 1 second at a time for the specified duration in seconds
        List<bool> boolList = new List<bool>();
        for (int i = 0; i < count; i++)
        {
            boolList.Add(setingValue);
        }
        return boolList;
    }
}