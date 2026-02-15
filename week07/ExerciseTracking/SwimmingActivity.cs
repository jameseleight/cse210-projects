public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (double)_laps * 50 / 1000;
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