public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int goalPoints, bool status)
        : base(name, description, goalPoints)
    {
        _status = status;
    }

    public override void CreateChildGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());

        _status = false;
    }

    public override void RecordEvent()
    {
        if (!_status)
        {
            _status = true;
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        return _status;
    }

    public override void ListGoal()
    {
        string statusSymbol = IsComplete() ? "X" : " ";
        Console.WriteLine($"[{statusSymbol}] {_name} ({_description})");
    }

    public override int CalculateAGP()
    {
        return IsComplete() ? _goalPoints : 0;
    }

    public override string SaveGoal()
    {
        return $"SimpleGoal:{_name},{_description},{_goalPoints},{IsComplete()}";
    }
}
