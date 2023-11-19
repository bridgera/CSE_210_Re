using System;

public class EternalGoal : BaseGoal
{
    public EternalGoal(User user) : base(user)
    {
        _goalType = "Eternal";

    }
    public EternalGoal (string goalType, bool isCompleted, string goalTitle, string description, int pointValue)
    : base(goalType, isCompleted, goalTitle, description, pointValue)
    {

    }

    public override void CompleteGoal()
    {
        _user.AddPoints(_pointValue);
        Console.WriteLine($"You earned {_pointValue} points!");
    }

    
}