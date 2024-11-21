public class EternalGoal : Goal
{
    private int _stepCounter;

    public EternalGoal(string name, string description, int goalPoints)
        : base(name, description, goalPoints)
    {
        _stepCounter = 0;
    }

    public override void CreateChildGoal()
    {
        Console.Write("Give your goal a title: ");
        _name = Console.ReadLine();
        
        Console.Write("Provide a description of your goal: ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());

        _stepCounter = 0;
    }

    public override void RecordEvent()
    {
        _stepCounter++;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void ListGoal()
    {
        string statusSymbol = " ";
        Console.WriteLine($"[{statusSymbol}] {_name} ({_description})");
    }

    public override int CalculateAGP()
    {
        return _goalPoints;
    }

    public override string SaveGoal()
    {
        return $"EternalGoal:{_name},{_description},{_goalPoints}";
    }
}
