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

    public ChecklistGoal (User user, string goalType, bool isCompleted, string goalTitle, string description, int pointValue,
    int timesCompleted, int timesNeeded, int bonusPoints)
    : base(user, goalType, isCompleted, goalTitle, description, pointValue)
    {
        _timesCompleted = timesCompleted;
        _timesNeeded = timesNeeded;
        _bonusPoints = bonusPoints;
    }


    public override void CompleteGoal()
    {
        if (_timesCompleted == (_timesNeeded - 1))
        {
           _user.AddPoints(_bonusPoints);
            Console.WriteLine($"You earned {_bonusPoints} points!");
            _timesCompleted = _timesCompleted + 1;
            _isCompleted = true; 
            
        }

        else
        {
            _user.AddPoints(_pointValue);
            Console.WriteLine($"You earned {_pointValue} points!");
            _timesCompleted = _timesCompleted + 1;
        }
        _user.Update(this);


    }

    public override int GetPointValue()
    {
        int combinedPoints = _pointValue;

        if (_timesCompleted == (_timesNeeded - 1))
        {
            combinedPoints = combinedPoints + _bonusPoints;
        }
        
        return combinedPoints;
    }

    public void CreateCheckHeadless()
    {

        string classString = $"{_goalType}|{_isCompleted}|{_goalTitle}|{_description}|{_pointValue}|{_timesCompleted}|{_timesNeeded}|{_bonusPoints}";

        _user.AddToList(classString);

        _user.SaveToFile();

    }

    public override string UpdateString()
    {
        string classString = $"{_goalType}|{_isCompleted}|{_goalTitle}|{_description}|{_pointValue}|{_timesCompleted}|{_timesNeeded}|{_bonusPoints}";
        return classString;
    }


    public override string AddGoalSpecificParameters()
    {
        Console.Write("Times needed to complete >");
        _timesNeeded = int.Parse(Console.ReadLine());

        Console.Write("Bonus points for completion >");
        _bonusPoints = int.Parse(Console.ReadLine());

        return $"{_timesCompleted}|{_timesNeeded}|{_bonusPoints}";
    }

    public override void DisplayGoal()
    {
        if (_isCompleted == true)
        {
            _checkIcon = "[x]";
        }

        Console.WriteLine($"{_checkIcon} {_goalTitle} ({_description}) [{_timesCompleted}/{_timesNeeded}]");
        
    }

    


}