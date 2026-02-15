public class ActivityManager
{
    private List<Activity> _activities = new List<Activity>();
    public ActivityManager()
    {

    }
    public void RunActivity()
    {
        DisplayWelcome();
        DateTime now = DateTime.Now;
        string todaydate = now.ToString("dd MMM yyyy");
        RunningActivity activity1 = new RunningActivity(todaydate, 120, 8);
        CyclingActivity activity2 = new CyclingActivity(todaydate, 65, 22);
        SwimmingActivity activity3 = new SwimmingActivity(todaydate, 30, 12);
        _activities.Add(activity1);
        _activities.Add(activity2);
        _activities.Add(activity3);
        Console.WriteLine();
        foreach (var item in _activities)
        {
            Console.WriteLine(item.GetSummary());
        }
        DisplayGoodbye();
    }   
    static void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Excersize Tracking Program!");
        Thread.Sleep(1000);
    }        
    static void DisplayGoodbye()
    {
        Console.WriteLine();
        Console.WriteLine("Thank you for running the Excersize Tracking Program.");
        Console.WriteLine();
    }
}