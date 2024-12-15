public class ChecklistGoal : Goal
{
    private int _amountCompleted; // Amount of time completed
    private int _target; // Set a target 
    private int _bonus; // Bonus points

    // Reuse Goal variables and the new ones
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Method complete the goal many times
    public override int RecordEvent()
    {
        _amountCompleted++; // Will increment each time 
        int pointsEarned = _points; 

        if (_amountCompleted == _target) // If they are equal
        {
            pointsEarned += _bonus; // Add the bonus and (Display a message of the bonus points earned) 
            Console.WriteLine($"\nGoal {_shortName} completed! You earned a bonus of {_bonus} points.");
        }

        Console.WriteLine($"\nYour Goal: ({_shortName}) has been registered");
        return pointsEarned; // Save total points 
    }

    // Method to storage the decision
    public override bool IsComplete()
    {
        return _amountCompleted >= _target; // The "_amountCompleted" should be bigger or equal
    }
    
    // Method to show the "status" of the goal 
    public override string GetDetailsString()
    {
        string status;
        if (IsComplete()) // If it IsComplete()
        {
            status = "[X]";
        }
        else 
        {
            status = "[ ]";
        }
        return $"{status} {_shortName} ({_description}) -- Completed: {_amountCompleted}/{_target} times"; 
    }

    // Method to storage the ChecklistGoal string
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }

    // Extra method to set the final completion of the Checklist
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}


