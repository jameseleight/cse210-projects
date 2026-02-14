using System;
// exceed requirements - I added a menu option to remove a goal so that the goals can be cleaned up as desired by the user
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}