public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // nothing to do here
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        // This method returns false always since an EternalGoal is never completed
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,,{_shortName},,{_description},,{_points}";
    }
}