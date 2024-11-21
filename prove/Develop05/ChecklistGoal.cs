public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _steps;
    private int _stepCounter;

    public ChecklistGoal(string name, string description, int goalPoints, int bonusPoints, int steps)
        : base(name, description, goalPoints)
    {
        _bonusPoints = bonusPoints;
        _steps = steps;
        _stepCounter = 0;
    }

    public override void CreateChildGoal()
    {
        Console.Write("What is the name of your checklist goal? ");
        _name = Console.ReadLine();
        
        Console.Write("Provide a description of your goal: ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());

        Console.Write("How many times do you need to complete this goal for the bonus? ");
        _steps = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus? ");
        _bonusPoints = int.Parse(Console.ReadLine());

        _stepCounter = 0;
    }

    public override void RecordEvent()
    {
        if (_stepCounter < _steps)
        {
            _stepCounter++;
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        return _stepCounter >= _steps;
    }

    public override void ListGoal()
    {
        string statusSymbol = IsComplete() ? "X" : " ";
        Console.WriteLine($"[{statusSymbol}] {_name} ({_description}) -- {_stepCounter}/{_steps} completed");
    }

    public override int CalculateAGP()
    {
        int points = _stepCounter * _goalPoints;
        if (IsComplete())
        {
            points += _bonusPoints;
        }
        return points;
    }

    public override string SaveGoal()
    {
        return $"ChecklistGoal:{_name},{_description},{_goalPoints},{_bonusPoints},{_steps},{_stepCounter}";
    }
}
