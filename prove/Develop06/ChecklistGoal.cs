public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int target) :base(name, description, 10)
    {
        _target = target;
        _bonus = 50;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"\nGoal completed and you have won {_bonus} bonus points!");
            Thread.Sleep(1000);
            return GetGoalPoints() + _bonus;
        }
        return GetGoalPoints();
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        return false;
    }
    public override string GetDetailsString()
    {
       if (IsComplete())
        {
            return $"[X] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        return $"[ ] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {GetGoalName()},{GetGoalDescription()},{_target},{_amountCompleted}";
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}