public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return GetDistance() / ((double)_duration / 60);
    }
    public override double GetPace()
    {
        return _duration / GetDistance();
    }
}