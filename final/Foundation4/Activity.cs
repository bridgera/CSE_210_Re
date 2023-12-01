using System;

public class Activity
{
    protected string _date;
    protected string _type;
    protected int _lengthInMinutes;
    protected double _distance;
    protected double _speed;
    protected double _pace;


    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }
    public virtual double GetSpeed()
    {
        return _speed;
    }
    public virtual double GetPace()
    {
        return _pace;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} | {_type} ({_lengthInMinutes} min) - {AdditionalInfo()} Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {Math.Round(GetPace(), 2)} min per km");
    }

    public virtual string AdditionalInfo()
    {
        return string.Empty;
    }
}