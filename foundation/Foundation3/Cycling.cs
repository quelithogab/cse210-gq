public class Cycling : Activity
{
    //The speed in kph
    private double _speed; 

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * GetLength()) / 60;
    public override double GetSpeed() => _speed;
    public override double GetPace() => 60 / _speed;

    public override string GetSummary()
    {
        return $"{GetDate().ToString("dd MMM yyyy")} Cycling ({GetLength()} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
