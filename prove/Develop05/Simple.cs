using System;

public class SimpleGoal : BaseGoal
{
    public SimpleGoal(User user) : base(user)
    {
        _goalType = "Simple";

    }

    public SimpleGoal (User user, string goalType, bool isCompleted, string goalTitle, string description, int pointValue)
    : base(user, goalType, isCompleted, goalTitle, description, pointValue)
    {

    }
    
}