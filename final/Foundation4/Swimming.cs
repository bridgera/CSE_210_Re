using System;

public class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, int lengthInMinutes, double laps) : base(date, lengthInMinutes)
    {
        _type = "Swimming";
        _laps = laps;
    }

    public override double GetSpeed()
    {
        _speed = (GetDistance() / _lengthInMinutes) * 60;
        return _speed;
    }
    public override double GetDistance()
    {
        _distance = (_laps * 50) / 1000;
        return _distance;
    }
    public override double GetPace()
    {
        _pace = _lengthInMinutes / GetDistance();
        return _pace;
    }

    public override string AdditionalInfo()
    {
        return $"Laps: {_laps},";
    }
}