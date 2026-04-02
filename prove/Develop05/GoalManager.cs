using System;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        int userChoice = -1;

        Console.WriteLine("Welcome to the Goal Program!");

        while (userChoice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("\nPlease select an option from the menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            
            userChoice = int.Parse(Console.ReadLine()); 

            if (userChoice == 1)
            {
                CreateGoal();
            }
            else if (userChoice == 2)
            {
                ListGoalDetails();
            }
            else if (userChoice == 3)
            {
                SaveGoals();
            }
            else if (userChoice == 4)
            {
                LoadGoals();
            }
            else if (userChoice == 5)
            {
                RecordEvent();
            }
            else
            {
                Console.WriteLine("Goodbye!");    
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1") _goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2") _goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        int gained = _goals[index].RecordEvent();
        _score += gained;
        Console.WriteLine($"Congratulations! You earned {gained} points!");
    }

    private void SaveGoals()
    {
        Console.Write("What is filename you want to save the goal to? ");
        string file = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (var g in _goals) sw.WriteLine(g.GetStringRepresentation());
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        if (!File.Exists(file)) return;

        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] d = parts[1].Split(',');

            if (type == "SimpleGoal") _goals.Add(new SimpleGoal(d[0], d[1], int.Parse(d[2]), bool.Parse(d[3])));
            else if (type == "EternalGoal") _goals.Add(new EternalGoal(d[0], d[1], int.Parse(d[2])));
            else if (type == "ChecklistGoal") _goals.Add(new ChecklistGoal(d[0], d[1], int.Parse(d[2]), int.Parse(d[3]), int.Parse(d[4]), int.Parse(d[5])));
        }
    }
}