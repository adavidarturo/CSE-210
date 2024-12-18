using System;

public abstract class Activity
{
    private DateTime _date; // I use DateTime instead of a string because it provides a standardized format and allows date operations and comparisons to be performed more efficiently.
    private int _duration; // min
    public Activity(DateTime date, int duration) // Initialize variables
    {
        _date = date;
        _duration = duration;
    }

    // Use Getters to acces to the base variables
    public DateTime GetDate() 
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }

    // Abstract and virtual classes to reuse
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Activity ({_duration} min)";
    }

}


