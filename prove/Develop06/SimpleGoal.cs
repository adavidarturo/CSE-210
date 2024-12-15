public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Reuse Goal variables
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    // Method to complete the goal
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal: {_shortName} -- Registered! You earned: {_points} points.");
        return _points; // Save earned points

    }
    
    // Method to storage the decision
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Method to storage the SimpleGoal string
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
    
    // Extra method to show the "status" of the goal 
    public override string GetDetailsString()
    {
        string status;
        if (IsComplete())
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }
        return $"{status} {_shortName} ({_description})";
    }
    
    // Extra method to set the completion of the goal
    public void SetCompletion(bool isComplete)
    {
        _isComplete = isComplete;
    }
}



