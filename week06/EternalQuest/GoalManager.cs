public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        List<Goal> _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        // Display Menu and collect choice and then complete action based on selection.  Run in while loop
        // Menu Options:
        // 1.  Create New Goal
        // 2. List Goals
        // 3. SAve Goals
        // 4. Load Goals
        // 5. Record Event
        // 6. Quit
    }
    public void DisplayPlayerInfo()
    {
        // Display "You have {_score} points"
        // Add writeline
    }
    public void ListGoalNames()
    {
        // used when listing the goals includes brackets and X based on if the goal is complete.
    }
    public void ListGoalDetails()
    {
        // used when listing the goals details are in ()
    }
    public void CreateGoal()
    {
        // add a new goal to the list of the selected type of goal
    }
    public void RecordEvent()
    {
        // find out which goal by listing the goals and then call the correct record event
    }
    public void SaveGoals()
    {
        // write to a file, default filename is goals.txt
    }
    public void LoadGoals()
    {
        // load from a file, default filename is goals.txt
    }
}