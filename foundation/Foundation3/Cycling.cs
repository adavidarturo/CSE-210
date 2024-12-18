public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed) // Initialize variables and speed
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60; // km
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed; // min/km
    }

    // Edit my GetSummary() method 
    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Cycling ({GetDuration()} min): Speed: {_speed} kph, Distance: {GetDistance()} km, Pace: {GetPace()} min per km";
    }
}



