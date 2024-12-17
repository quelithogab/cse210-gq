using System;

public abstract class Activity
{
    private DateTime _date;
    //  The legnth in minutes
    private int _length; 

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate() => _date;
    public int GetLength() => _length;

    public abstract double GetDistance(); //The distance in km or miles
    public abstract double GetSpeed();    //The speed in kph or mph
    public abstract double GetPace();     // The pace in min per km or min per mile

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_length} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
