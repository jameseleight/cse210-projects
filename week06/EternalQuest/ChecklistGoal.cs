public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        // increment _amountCompleted
        _amountCompleted++;
        // check to see if the target has been reached
        // if not just add the points to the total.  if so, then also add the bonus points and change _isComplete to true  If there are more completions just add points
        // Add the points for this goal to the total
        // display to console "Congratulations! you have earned {_points} points"
        // display to console "You now have {totalpoints} points.
    }
    public override bool IsComplete()
    {
        // check if the target has been achived and if so then return true.  otherwise, return false.
        return false;
    }
    public override string GetDetailsString()
    {
        // return description
        return _description;
    }
    public override string GetStringRepresentation()
    {
        // used to write to a file.
        return "test";
    }
}