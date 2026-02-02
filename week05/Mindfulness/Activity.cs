using System;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity()
    {
        // load default value for the attributes
    }
    public void DisplayStartingMessage()
    {
        // display to the console the _name of the activity and the _description
        // display and collect input on the console for the duration of the activity
    }
    public void DisplayEndingMessage()
    {
        // display to the console the message that tells the user they did a good job, pause, display to the console the name of the activity and the length of time.  Then finish/done.
    }
    public void ShowSpinner(int seconds)
    {
        // run the spinner annimation for the specified duration in seconds
    }
    public void ShowCountDown(int seconds)
    {
        // display a countdown in seconds for the specified duration in seconds
    }
}