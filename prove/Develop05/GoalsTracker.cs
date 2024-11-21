using System;
using System.Collections.Generic;
using System.IO;

public class GoalsTracker
{
    public List<Goal> Goals { get; private set; } = new List<Goal>();
    private int _accumulatedPoints;

    public int GetAccumulatedPoints() => _accumulatedPoints;

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename to save to? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_accumulatedPoints);
            foreach (var goal in Goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename to load from? ");
        string fileName = Console.ReadLine();
        var lines = File.ReadAllLines(fileName);
        _accumulatedPoints = int.Parse(lines[0]);

        Goals.Clear();

        foreach (var line in lines.Skip(1))
        {
            var parts = line.Split(":");
            if (parts[0] == "SimpleGoal")
            {
                var goalParts = parts[1].Split(",");
                AddGoal(new SimpleGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]), bool.Parse(goalParts[3])));
            }
            else if (parts[0] == "EternalGoal")
            {
                var goalParts = parts[1].Split(",");
                AddGoal(new EternalGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                var goalParts = parts[1].Split(",");
                AddGoal(new ChecklistGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]), int.Parse(goalParts[3]), int.Parse(goalParts[4])));
            }
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Your goals:");
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i]}");
        }
    }

    public void RecordEventInTracker()
    {
        Console.Write("Enter the number of the goal you completed: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < Goals.Count)
        {
            Goals[index].RecordEvent();
            _accumulatedPoints += Goals[index].CalculateAGP();
            Console.WriteLine($"You earned {Goals[index].CalculateAGP()} points! Total points: {_accumulatedPoints}");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
}
