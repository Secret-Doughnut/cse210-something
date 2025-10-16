public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;


    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        
        int pointreward = int.Parse(_points);
        int number = pointreward;

        _amountCompleted += 1;

        bool Answer = IsComplete();

        if (Answer == true)
        {
            number = _bonus;
        }

        return number;
    }

    public override bool IsComplete()
    {
        bool check = false;

        if (_amountCompleted == _target)
        {
            check = true;
        }
        
        return check;
    }


    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }
    
    public void SetAmountCompleted(int number)
    {
        _amountCompleted = number;
    }
}