public class EternalGoal : Goal
{
    // Reuse Goal variables
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    // Method to complete the goal
    public override int RecordEvent()
    {
        Console.WriteLine($"\nGoal: {_shortName}  -- Registered! You earned: {_points} points.");
        return _points; // Save earned points again
    }
    
    // Method to storage the decision
    public override bool IsComplete()
    {
        return false; // Never complete
    }

    // Method to storage the EternalGoal string
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}



