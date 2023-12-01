using System;

public class Cycling : Activity
{
    public Cycling(string date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _type = "Cycling";
        _distance = distance;
    }

    public override double GetSpeed()
    {
        _speed = (_distance / _lengthInMinutes) * 60;
        return _speed;
    }
    public override double GetPace()
    {
        _pace = _lengthInMinutes / _distance;
        return _pace;
    }
}