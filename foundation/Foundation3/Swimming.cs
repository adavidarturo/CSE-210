public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps) // Initialize variables and laps
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // km 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60; // km/h
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance(); // min/km
    }

    // Edit my GetSummary() method 
    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({GetDuration()} min): Laps: {_laps}, Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }
}


