public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
    public string GetNameString()
    {
        return _shortName;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public virtual void SetStatus(bool state, int value)
    {
        // this will be overridden as needed.  It is virtual so that a child class does not need to implement it if not needed.
    }
    public abstract string GetStringRepresentation();
}