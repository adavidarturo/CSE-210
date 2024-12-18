public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int duration, double distance) // Initialize variables and distance
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60; // km/h
    }

    public override double GetPace()
    {
        return GetDuration() / _distance; // min/km
    }

    // Edit my GetSummary() method 
    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Running ({GetDuration()} min): Distance {_distance} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}


