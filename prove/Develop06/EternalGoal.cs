public class EternalGoal : Goal
{
    public EternalGoal(string name, string description) :base(name, description, 30)
    {
        
    }

    public override int RecordEvent()
    {
        return GetGoalPoints();
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
       return $"EternalGoal: {GetGoalName()},{GetGoalDescription()}";
    }
}