using System.Data;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        // change _isCompelte to true when called
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,,{_shortName},,{_description},,{_points},,{IsComplete()}";
    }
    public override void SetStatus(bool state, int value)
    {
        _isComplete = state;
    }
}