using System;

public class EternalGoal : BaseGoal
{
    public EternalGoal(User user) : base(user)
    {
        _goalType = "Eternal";
        _checkIcon = "[∞]";

    }
    public EternalGoal (User user, string goalType, bool isCompleted, string goalTitle, string description, int pointValue)
    : base(user, goalType, isCompleted, goalTitle, description, pointValue)
    {

    }

    public override void CompleteGoal()
    {
        _user.AddPoints(_pointValue);
        Console.WriteLine($"You earned {_pointValue} points!");
    }

    public override void DisplayGoal()
    {
        _checkIcon = "[∞]";
        Console.WriteLine($"{_checkIcon} {_goalTitle} ({_description})");
    }

    
}