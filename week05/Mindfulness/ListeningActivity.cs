using System;
public class ListeningActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListeningActivity()
    {
        // load default value for the attributes
    }
    public void Run()
    {
        // Display the welcome message form the Activity parent class
        // Prompt for the duration of the activity from the activity parent class
        // provide the description for the lisenting activity class
        // randomly select the prompt
        // display the prompt
        // Show a countdown for them to think of items to type into a list
            // Collect and prompt to keep listing items until timer ends
        // display back the number of items they provided
        // display the goodbye message from the Activity parent class
    }
    public void GetRandomPrompt()
    {
        // Pick a prompt at random
    }
    public void GetListFromUser()
    {
        // Get a list from the user they enter for the prompted topic
    }
}