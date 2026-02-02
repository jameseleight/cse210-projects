using System;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity()
    {
        // load default value for the attributes
    }
    public void Run()
    {
        // Display the welcome message form the Activity parent class
        // Prompt for the duration of the activity from the activity parent class
        // provide the description for the lisenting activity class
        // randomly select the prompt
        // display the prompt and add a pause/delay
        // randomly select a question
        // display the question
        // pause and display the spinner for a duration
        // randomly select another question, etc. until the duration ends
        // display the goodbye message from the Activity parent class
    }
    public string GetRandomPrompt()
    {
        // Pick a prompt at random
        return "";
    }
    public string GetRandomQuestion()
    {
        // Pick a question at random
        return "";
    }
    public void DisplayPrompt()
    {
        // Display the selected prompt
    }
    public void DisplayQuestion()
    {
        // Display the selected question
    }
}