public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description) :base(name, description, 20)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        SetComplete();
        return GetGoalPoints();
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {GetGoalName()},{GetGoalDescription()},{_isComplete}";
    }
    public void SetComplete()
    {
        _isComplete = true;
    }

}