public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected string _points = "";

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points; 
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        string Answer = $"{_shortName} ({_description})";

        return Answer;
    }
}