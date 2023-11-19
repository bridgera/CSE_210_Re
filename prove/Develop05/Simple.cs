using System;

public class SimplelGoal : BaseGoal
{
    public SimplelGoal(User user) : base(user)
    {
        _goalType = "Simple";

    }

    public SimplelGoal (string goalType, bool isCompleted, string goalTitle, string description, int pointValue)
    : base(goalType, isCompleted, goalTitle, description, pointValue)
    {

    }
    
}