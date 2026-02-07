using System;
public class ListeningActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private List<bool> _promptsUnused = new List<bool>();
    private int _totalTime;
    public ListeningActivity()
    {
        _name = "Listening";
        _description = "This activity will help you reflect on the good things in your life "
                        + "by having you list as many things as you can in a certain area.";
        _totalTime = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _promptsUnused = CreateBoolList(_prompts.Count, true);
    }
    public void Run()
    {
        DisplayStartingMessage();
        Listen(_duration);
        _totalTime += _duration;
        DisplayResult();
        DisplayEndingMessage(_totalTime);
    }
    public void Listen(int seconds)
    {
        (string listenPrompt, _promptsUnused) = GetRandomPrompt(_prompts, _promptsUnused);
        DisplayPrompt(listenPrompt);
        DisplayPreparation();

        // set up start and end times to run duraiton of the activity
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            responses = GetListFromUser(responses);
        }
        _count = responses.Count;
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
    public List<string> GetListFromUser(List<string> enterData)
    {
        Console.Write("> ");
        string userResponse = Console.ReadLine();
        enterData.Add(userResponse);
        return enterData;
    }
    public void DisplayPrompt(string text)
    {
        Console.WriteLine();
        Console.Write("List as many responses you can to the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {text} --- ");
    }
    public void DisplayPreparation()
    {
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
    }
    public void DisplayResult()
    {
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
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