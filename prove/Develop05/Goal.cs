public class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;

    public Goal() 
    {
        _name = "Test Name";
        _description = "Test Description";
        _goalPoints = 50;
        _status = false;
    }

    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    public virtual string SaveGoal()
    {
        return string.Empty;
    }

    public virtual void CreateChildGoal()
    {
    }

    public virtual void RecordEvent()
    {
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual void ListGoal()
    {
    }

    public virtual int CalculateAGP()
    {
        return 0;
    }
}
