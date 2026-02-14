using System.ComponentModel.Design;
using System.IO;
using System.IO.Enumeration;
using System.Threading.Tasks.Sources;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
        DisplayWelcome();
        string selection = "-1";
        while (selection != "7")
        {
            DisplayPlayerInfo();
            DisplayMenuChoices();   
            selection = Console.ReadLine();
            if (selection == "1")
            {
                CreateGoal();
            }
            else if (selection == "2")
            {
                ListGoalDetails();
            }
            else if (selection == "3")
            {
                SaveGoals();
            }
            else if (selection == "4")
            {
                LoadGoals();
            }
            else if (selection == "5")
            {
                RecordEvent();
            }
            else if (selection == "6")
            {
                RemoveGoal();
            }                 
            else if (selection == "7")
            {
                DisplayGoodbye();
            }            
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please select a valid choice (1-7).");
            }
        }
    }
    static void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Thread.Sleep(2000);
    }        
    static void DisplayGoodbye()
    {
        Console.Clear();
        Console.WriteLine("Thank you for running the Eternal Quest Program.");
        Console.WriteLine();
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
    }
    public void CreateGoal()
    {
        int selectedType = -1;
        while (selectedType < 1 || selectedType > 3)
        {
            DisplayGoalTypes();
            selectedType = int.Parse(Console.ReadLine());
            if (selectedType < 1 && selectedType > 3)
            {
                Console.WriteLine("Please make a valid integer selection in 1-3.");
            }
            else
            {
                if (selectedType == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal newGoal = new SimpleGoal(name, description, points);
                    _goals.Add(newGoal);
                }
                else if (selectedType == 2)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    EternalGoal newGoal = new EternalGoal(name, description, points);
                    _goals.Add(newGoal);
                }
                else if (selectedType == 3)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(newGoal);
                }
            }
        }
    }
    public void ListGoalDetails()
    {
        int index = 1;
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("There are currently no Goals.");
        }
        foreach (var item in _goals)
        {
            string completeFlag = " ";
            if (item.IsComplete())
            {
                completeFlag = "X";
            }
            Console.WriteLine($"{index}. [{completeFlag}] {item.GetDetailsString()}");
            index++;
        }
    }
    public void ListGoalNames()
    {
        int index = 1;
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        foreach (var item in _goals)
        {
            Console.WriteLine($"{index}. {item.GetNameString()}");
            index++;
        }
    }
    public void SaveGoals()
    {
        Console.WriteLine();
        Console.Write("What is the filename for the goal file (hit enter for default = goals.txt)? ");
        string fileName = Console.ReadLine();
        if (fileName == "")
        {
            fileName = "goals.txt";
        }
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (var item in _goals)
            {
            outputFile.WriteLine(item.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        _goals.Clear();
        Console.WriteLine();
        Console.Write("What is the filename for the goal file (hit enter for default = goals.txt)? ");
        string fileName = Console.ReadLine();
        if (fileName == "")
        {
            fileName = "goals.txt";
        }
        string[] lines = System.IO.File.ReadAllLines(fileName);
        bool firstLine = true;
        foreach (string line in lines)
        {
            if (firstLine)
            {
                _score = int.Parse(lines[0]);
                firstLine = false;
            }
            else
            {
                string[] parts = line.Split(",,");
                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal newGoal0 = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    newGoal0.SetStatus(bool.Parse(parts[4]), 0);
                    _goals.Add(newGoal0);
                }
                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal newGoal1 = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(newGoal1);
                }
                else // Checklist goal
                {
                    ChecklistGoal newGoal2 = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    newGoal2.SetStatus(true, int.Parse(parts[6]));
                    _goals.Add(newGoal2);
                }
            }
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        int goalSelected = -1;
        while (goalSelected < 1 || goalSelected > _goals.Count)
        {
            Console.Write($"Which goal did you accomplish (choose 1-{_goals.Count})? ");
            goalSelected = int.Parse(Console.ReadLine());
            if (goalSelected < 1 || goalSelected > _goals.Count)
            {
                Console.WriteLine("Please select a valid number for the goal");
            }
            else
            {
                _goals[goalSelected - 1].RecordEvent();
                Console.WriteLine();
                Console.WriteLine($"Congratulations! You have earned {_goals[goalSelected - 1].GetPoints()} points.");
                _score += _goals[goalSelected - 1].GetPoints();
            }
        }
    }
    public void RemoveGoal()
    {
        ListGoalDetails();
        int initialCount = _goals.Count;
        int removeSelected = -1;
        while (removeSelected < 0 || removeSelected > initialCount)
        {
            Console.Write($"Which goal would you like to remove? (1-{initialCount}) select 0 to abort ");
            removeSelected = int.Parse(Console.ReadLine());
            if (removeSelected < 0 || removeSelected > initialCount)
            {
                Console.WriteLine("Please provide a valid response.");
            }
            else if (removeSelected == 0)
            {
                // do nothing 
            }
            else
            {
                _goals.RemoveAt(removeSelected - 1);
            }
        }
    }
    static void DisplayGoalTypes()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create (1-3)? ");
    }
    static void DisplayMenuChoices()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Remove Goal");
        Console.WriteLine("  7. Quit");
        Console.Write("Select a choice from the menu (1-7): ");
    }
}