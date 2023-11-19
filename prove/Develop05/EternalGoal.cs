using System;

public class EternalGoal : BaseGoal
{
    public EternalGoal(User user) : base(user)
    {
        _goalType = "Eternal";

    }

    public override void CompleteGoal()
    {
        _user.AddPoints(_pointValue);
        Console.WriteLine($"You earned {_pointValue} points!");
    }

    
}