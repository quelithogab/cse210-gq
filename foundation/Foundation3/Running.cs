public class Running : Activity
{
    // The distance in km
    private double _distance; 

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / GetLength()) * 60;
    public override double GetPace() => GetLength() / _distance;

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Running ({GetLength()} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
