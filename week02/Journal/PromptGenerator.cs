using System;
public class PromptGenerator
{
    public List<string> _prompt = new List<string>
    {
        "What was the best part of my day?",
        "What was the worst part of my day?",
        "How did I provide service to someone today?",
        "What was the most spiritual experience I had today?",
        "What was a problem that I struggled with today?",
        "What is something that strengthened my testimony of Jesus Christ today?",
        "What was one thing I wish I could do over today?"
    };
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int randint = rnd.Next(0,7);
        return _prompt[randint];
    }
    public void DisplayPrompts()
    {
        Console.WriteLine("The current stored prompts are the following:");
        int index = 0;
        foreach (string item in _prompt)
        {
            Console.WriteLine($"Index: {index}, Prompt: {item}");
            index++;
        }
        Console.WriteLine();
    }
}