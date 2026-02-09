public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        // Add the points for this goal to the total
        // display to console "Congratulations! you have earned {_points} points"
        // display to console "You now have {totalpoints} points.
    }
    public override bool IsComplete()
    {
        // This method returns false always since an EternalGoal is never completed
        return false;
    }
    public override string GetStringRepresentation()
    {
        // used to write to a file
        return "test";
    }
}