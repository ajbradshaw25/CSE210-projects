using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        Console.WriteLine($"You have {_score} points."); 
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals) Console.WriteLine(goal.GetDetailsString()); 
    }

    public void CreateGoal()
    {
        // Ask user for type, name, description, and points, then add to _goals
    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals) outputFile.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), 
                                            int.Parse(data[4]), int.Parse(data[3]), int.Parse(data[5])));
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}