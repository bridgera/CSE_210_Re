using System;
using System.IO;
using System.Dynamic;
using System.Text.Json;

public class User
{
    private int _points;
    private string _username;
    private List<string> _goalList = new List<string>();
    private List<BaseGoal> _goalObjList = new List<BaseGoal>();
    private string _goalsPath;
    private string _pointPath;
    private string _directoryPath;
    

    public User(string username)
    {
        _username = username;

    }

    public void LoadFiles()
    {
        _goalList.Clear();
        _goalObjList.Clear();
        _directoryPath = $"SaveData/{_username}";
        _goalsPath = $"{_directoryPath}/Goals.txt";
        _pointPath = $"{_directoryPath}/Point.txt";

        Directory.CreateDirectory(_directoryPath);

        if (!File.Exists(_goalsPath))
        {
            File.Create(_goalsPath).Close();
        }

        if (!File.Exists(_pointPath))
        {
            File.WriteAllText(_pointPath, "0");
            _points = int.Parse(File.ReadAllText(_pointPath));
        }
        
        else if (File.Exists(_pointPath))
        {
            _points = int.Parse(File.ReadAllText(_pointPath));
        }
        

        string[] goalArray = System.IO.File.ReadAllLines(_goalsPath);

        foreach (string goal in goalArray)
        {
            string[] attributes = goal.Split("|");

            string goalType = attributes[0];
            string isCompleted = attributes[1];
            bool isCompletedBool = bool.Parse(isCompleted);
            string goalTitle = attributes[2];
            string description = attributes[3];
            int pointValue = int.Parse(attributes[4]);
            

        
            if (goalType == "Simple")
            {
                SimpleGoal simpleGoal = new SimpleGoal(this, goalType, isCompletedBool, goalTitle, description, pointValue);
                _goalObjList.Add(simpleGoal);
                simpleGoal.CreateGoal(true);
            }

            else if (goalType == "Eternal")
            {
                EternalGoal eternalGoal = new EternalGoal(this, goalType, isCompletedBool, goalTitle, description, pointValue);
                _goalObjList.Add(eternalGoal);
                eternalGoal.CreateGoal(true);
            }
            else if (goalType == "Checklist")

            {
                int timesCompleted = int.Parse(attributes[5]);
                int timesNeeded = int.Parse(attributes[6]);
                int bonusPoints = int.Parse(attributes[7]);

                ChecklistGoal checklistGoal = new ChecklistGoal(this, goalType, isCompletedBool, goalTitle, description, pointValue, timesCompleted, timesNeeded, bonusPoints);
                _goalObjList.Add(checklistGoal);
                checklistGoal.CreateCheckHeadless();

            }


            // Console.WriteLine($"Total goals to display: {_goalObjList.Count}");

            // Console.ReadLine();

            
        }
        
    }

    public void ShowGoals()
    {

        string userInput = "";

        int earnedPoints = 0;

        while (userInput != "Q")
        {
            Console.Clear();

            if (earnedPoints > 0)
            {
                Console.WriteLine($"You Earned {earnedPoints} points!!");
            }
            
            int currentGoalNum = 1;
            
            if (_goalObjList.Count == 0)
            {
                Console.WriteLine("You have made no goals.");
            }
            
            
            foreach (BaseGoal goal in _goalObjList)
            {
                Console.WriteLine($"Loaded goal: {goal.ToString()}");
                Console.Write(currentGoalNum + ". ");
                goal.DisplayGoal();
                currentGoalNum = currentGoalNum + 1;
                // Console.ReadLine();
            }
            Console.WriteLine("To mark off a goal type it's number (or quit by typing Q)");
            userInput = Console.ReadLine().ToUpper();

            if (userInput != "Q")
            {
                int userInt = int.Parse(userInput) -1;
                _goalObjList[userInt].CompleteGoal();
                earnedPoints = _goalObjList[userInt].GetPointValue();
            }
        }
    }

    public void Update(BaseGoal updatingGoal)
    {
        for (int i = 0; i < _goalObjList.Count; i++)
        {
            if (_goalObjList[i] == updatingGoal)
            {
                string goalString = _goalObjList[i].UpdateString();
                _goalList[i] = goalString; 
                break; 
            }
        }
        this.SaveToFile();
    }


    public void AddToList(string goal)
    {
        _goalList.Add(goal);
    }

    public void SaveToFile()
    {

        using (StreamWriter outputFile = new StreamWriter(_goalsPath))
        {
            foreach (string goalString in _goalList)
            {
                outputFile.WriteLine(goalString);
            }
        }
        
    }


    public int GetPoints()
    {
        return _points;
    } 

    public void AddPoints(int pointAmount)
    {
        _points = _points + pointAmount;
        File.WriteAllText(_pointPath, "");
        File.WriteAllText(_pointPath, _points.ToString());
    }



}