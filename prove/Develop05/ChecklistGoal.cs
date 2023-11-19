using System;

public class ChecklistGoal : BaseGoal
{
    int _timesCompleted;
    int _timesNeeded;
    int _bonusPoints;

    public ChecklistGoal(User user) : base(user)
    {
        _goalType = "Checklist";

    }

    public ChecklistGoal (string goalType, bool isCompleted, string goalTitle, string description, int pointValue)
    : base(goalType, isCompleted, goalTitle, description, pointValue)
    {

    }


    public override void CompleteGoal()
    {
        if (_timesCompleted == _timesNeeded)
        {
           _user.AddPoints(_bonusPoints);
            Console.WriteLine($"You earned {_bonusPoints} points!");


            _isCompleted = true; 
        }

        else
        {
            _user.AddPoints(_pointValue);
            Console.WriteLine($"You earned {_pointValue} points!");
        }


    }

    public override string AddGoalSpecificParameters()
    {
        Console.Write("Times needed to complete >");
        _timesNeeded = int.Parse(Console.ReadLine());

        Console.Write("Bonus points for completion >");
        _bonusPoints = int.Parse(Console.ReadLine());

        return $"{_timesNeeded}|{_bonusPoints}";
    }


}