public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Initialize variables
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // The abstract method I'll use
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    // Virtual method to reuse
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }
}


