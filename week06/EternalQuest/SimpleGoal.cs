using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;


    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        _isComplete = true;
        int pointreward = int.Parse(_points);

        return pointreward;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{IsComplete()}";
    }

    public void SetIsComplete(bool check)
    {
        _isComplete = check;
    }

}