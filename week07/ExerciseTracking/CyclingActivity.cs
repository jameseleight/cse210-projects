public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (double)_duration / 60 * _speed;
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