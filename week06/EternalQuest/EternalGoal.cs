public class EternalGoal : Goal
{
    
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        int pointreward = int.Parse(_points);
        return pointreward;
    }

    public override bool IsComplete()
    {
        return false;
    }


    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }
}