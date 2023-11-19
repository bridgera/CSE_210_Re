using System;

public class BaseGoal
{
    protected User _user;
    protected string _goalType;
    protected string _goalTitle;
    protected string _description;
    protected int _pointValue;
    protected bool _isCompleted;
    protected string _checkIcon = "[ ]";

    //New goal constructor
    public BaseGoal (User user)
    {
        _user = user;
    }

    //Loading goal constructor
    public BaseGoal (string goalType, bool isCompleted, string goalTitle, string description, int pointValue)
    {
        _goalType = goalType;
        _isCompleted = isCompleted;
        _goalTitle = goalTitle;
        _description = description;
        _pointValue = pointValue;
    }


    public virtual void CompleteGoal()
    {
        _user.AddPoints(_pointValue);
        Console.WriteLine($"You earned {_pointValue} points!");
        _isCompleted = true;
    }

    public void CreateGoal()
    {
        Console.Write("Goal Title >");
        _goalTitle = Console.ReadLine();

        Console.Write("Points per completion >");
        _pointValue = int.Parse(Console.ReadLine());

        Console.Write("Description >");
        _description = Console.ReadLine();

        string specificParam = AddGoalSpecificParameters();

        string classString = $"{_goalType}|{_isCompleted}|{_goalTitle}|{_description}|{_pointValue}|{specificParam}";

        _user.AddToList(classString);

        _user.SaveToFile();

    }

    public virtual string AddGoalSpecificParameters()
    {
        return "";
    }

    public void DisplayGoal()
    {
        if (_isCompleted == true)
        {
            _checkIcon = "[x]";
        }

        Console.WriteLine($"{_checkIcon} {_goalTitle} ({_description})");
        
    }


    
}