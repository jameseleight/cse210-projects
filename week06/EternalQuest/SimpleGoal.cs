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
        // Add the points for this goal to the total
        // display to console "Congratulations! you have earned {_points} points"
        // display to console "You now have {totalpoints} points.
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        // used to create a string to write to file
        return "test";
    }
}