using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<bool> _promptsUnused = new List<bool>();
    private List<string> _questions = new List<string>();
    private List<bool> _questionsUnused = new List<bool>();
    private int _totalTime;
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _promptsUnused = CreateBoolList(_prompts.Count, true);
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _questionsUnused = CreateBoolList(_questions.Count, true);
        _totalTime = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Reflect(_duration);
        _totalTime += _duration;
        DisplayEndingMessage(_totalTime);
    }
    public void Reflect(int seconds)
    {
        (string prompt1, _promptsUnused) = GetRandomPrompt(_prompts, _promptsUnused);
        DisplayPrompt(prompt1);
        DisplayPreparation();
        // Set up for running activity over duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        // put display to top and then run reflecting questions
        Console.Clear();
        while (DateTime.Now < endTime)
        {
            (string questiontext, _questionsUnused) = GetRandomQuestion(_questions, _questionsUnused);
            DisplayQuestion(questiontext);
        }
    }
    public (string, List<bool>) GetRandomPrompt(List<string> prompts, List<bool> unUsed)
    {
        // check if all the prompts have been used and the unUsed list is all false and if so, then reset to all true values
        if (ValidateUnUsed(unUsed))
        {
            unUsed = CreateBoolList(unUsed.Count, true);
        }
        // make a list of the unUsed idicies
        List<int> unUsedIndicies = MakeListUnUsed(unUsed);
        // Pick one of the unUsed indicies at random
        Random randomGenerator = new Random();
        int promptLength = unUsedIndicies.Count;
        int randomIndex = randomGenerator.Next(0,promptLength);
        // get the index randomly picked and use that index to set the unUsed item to false and then return the prompt/question for that index
        unUsed[unUsedIndicies[randomIndex]] = false;
        return (prompts[unUsedIndicies[randomIndex]], unUsed);
    }
    public (string, List<bool>) GetRandomQuestion(List<string> questions, List<bool> unUsed)
    {
        // check if all the prompts have been used and the unUsed list is all false and if so, then reset to all true values
        if (ValidateUnUsed(unUsed))
        {
            unUsed = CreateBoolList(unUsed.Count, true);
        }
        // make a list of the unUsed idicies
        List<int> unUsedIndicies = MakeListUnUsed(unUsed);
        // Pick one of the unUsed indicies at random
        Random randomGenerator = new Random();
        int promptLength = unUsedIndicies.Count;
        int randomIndex = randomGenerator.Next(0,promptLength);
        unUsed[unUsedIndicies[randomIndex]] = false;
        return (questions[unUsedIndicies[randomIndex]], unUsed);
    }
    public void DisplayPrompt(string promptText)
    {
        // Display the selected prompt
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {promptText} ---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
    }
    public void DisplayPreparation()
    {
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following quesitons as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
    }  
    public void DisplayQuestion(string questionText)
    {
        Console.Write(questionText + " ");
        ShowSpinner(5);
        Console.WriteLine();
    }    
    public bool ValidateUnUsed(List<bool> listCheck)
    {
        if (listCheck.All(f => f == false))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public List<int> MakeListUnUsed(List<bool> listCheck)
    {
        int indexCount = 0;
        List<int> indicies = new List<int>();
        foreach (var item in listCheck)
        {
            if (item == true)
            {
                // the value of the index is only added to the list if it is true and unused in the prompts/questions
                indicies.Add(indexCount);
            }
            indexCount++;
        }
        return indicies;
    }
}