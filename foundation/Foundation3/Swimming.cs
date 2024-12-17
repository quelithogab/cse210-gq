public class Swimming : Activity
{
    //The number of laps
    private int _laps; 

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    // convert the meters to km
    public override double GetDistance() => _laps * 50.0 / 1000; 
    public override double GetSpeed() => (GetDistance() / GetLength()) * 60;
    public override double GetPace() => GetLength() / GetDistance();

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Swimming ({GetLength()} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
