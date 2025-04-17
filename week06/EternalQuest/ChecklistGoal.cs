public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        bool complete;
        
        if (_amountCompleted == _target)
        {
            complete = true;
        }

        else
        {
            complete = false;
        }
        
        return complete;
    }

    // public override GetDetailsString()
    // {
    // }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}