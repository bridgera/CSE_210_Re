using System;
using System.IO;
using System.Dynamic;
using System.Text.Json;

public class User
{
    private int _points;
    private string _username;
    private List<string> _goalList = new List<string>();
    private string _goalsPath;
    private string _pointPath;
    private string _directoryPath;

    public User(string username)
    {
        _username = username;
        
    }

    public void LoadFiles(bool display)
    {
        _directoryPath = $"SaveData/{_username}";
        _goalsPath = $"{_directoryPath}/Goals.txt";
        _pointPath = $"{_directoryPath}/Point.txt";

        Directory.CreateDirectory(_directoryPath);

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
            string timesCompleted = attributes[5];
            string timesNeeded = attributes[6];
            string bonusPoints = attributes[7];

            if (goalType == "Simple")
            {
                SimplelGoal simplelGoal = new SimplelGoal(goalType, isCompletedBool, goalTitle, description, pointValue);
                if(display == true)
                {
                    simplelGoal.DisplayGoal();
                }
            }

            else if (goalType == "eternal")
            {
                EternalGoal eternalGoal = new EternalGoal(goalType, isCompletedBool, goalTitle, description, pointValue);
                if(display == true)
                {
                    eternalGoal.DisplayGoal();
                }
            }
            else if (goalType == "eternal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(goalType, isCompletedBool, goalTitle, description, pointValue);
                if(display == true)
                {
                    checklistGoal.DisplayGoal();
                }
            }

        }



        
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
        _points =+ pointAmount;
        File.WriteAllText(_pointPath, "");
        File.WriteAllText(_pointPath, _points.ToString());
    }



}