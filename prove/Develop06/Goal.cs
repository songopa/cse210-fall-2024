public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetGoalName()
    {
        return _shortName;
    }
    public string GetGoalDescription()
    {
        return _description;
    }
    public int GetGoalPoints()
    {
        return _points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        return $"[ ] {_shortName} ({_description})";
    }
}