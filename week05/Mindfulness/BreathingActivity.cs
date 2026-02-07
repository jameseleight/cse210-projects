using System;
public class BreathingActivity : Activity
{
    private int _totalTime;
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing "
                     + "in and out slowly. Clear your mind and focus on your breathing.";
        _totalTime = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Breathe(_duration);
        _totalTime += _duration;
        DisplayEndingMessage(_totalTime);
    }
    public void Breathe(int seconds)
    {
        // set up start and end times to run duraiton of the animation
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in ... ");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out ... ");
            ShowCountDown(5);
            Console.WriteLine();
        }
    }
}