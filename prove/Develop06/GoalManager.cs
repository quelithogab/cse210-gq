using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private static GoalManager _instance;
    private List<Goal> _goals;
    private int _score;
    private int _level;

    private GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
    }

    public static GoalManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GoalManager();
            }
            return _instance;
        }
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            if (choice == "1") CreateGoal();
            else if (choice == "2") RecordEvent();
            else if (choice == "3")
            {
                Console.Clear();
                ListGoalDetails();
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
            else if (choice == "4") SaveGoals();
            else if (choice == "5") LoadGoals();
            else if (choice == "6") break;
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Level: {_level}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter  the goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter the target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else if (choice == "4")
        {
            _goals.Add(new NegativeGoal(name, description, points));
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Choose a goal to record an event: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        _goals[choice].RecordEvent();

        if (_score >= _level * 1000)
        {
            _level++;
            Console.WriteLine("Congratulations! You leveled up!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    public void AddPoints(int points)
    {
        _score += points;
    }

    public void DeductPoints(int points)
    {
        _score -= points;
    }

    public void SaveGoals()
    {
        Console.Write("Enter the name of the file to save the goals: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_level);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter the name of the file to load the goals: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);
        _goals.Clear();
        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string[] details = parts[1].Split(",");

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                if (bool.Parse(details[3])) goal.RecordEvent();
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]));
                for (int j = 0; j < int.Parse(details[5]); j++) goal.RecordEvent();
                _goals.Add(goal);
            }
            else if (goalType == "NegativeGoal")
            {
                NegativeGoal goal = new NegativeGoal(details[0], details[1], int.Parse(details[2]));
                _goals.Add(goal);
            }
        }
    }
}
