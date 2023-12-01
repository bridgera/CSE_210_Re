using System;

public class Running : Activity
{
    public Running(string date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _type = "Running";
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