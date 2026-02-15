public abstract class Activity
{
    protected string _date;
    protected int _duration;
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        string typeName = GetType().Name;
        string type0 = "";
        if (typeName == "RunningActivity")
        {
            type0 = "Running";
        }
        else if (typeName == "CyclingActivity")
        {
            type0 = "Cycling";
        }
        else if (typeName == "SwimmingActivity")
        {
            type0 = "Swimming";
        }
        return $"{_date} {type0} ({_duration} min): Distance = {GetDistance().ToString("F2")} km, Speed = {GetSpeed().ToString("F2")} kph, Pace = {GetPace().ToString("F2")} mpk";
    }
}