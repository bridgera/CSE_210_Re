using System;
using System.IO;
using System.Dynamic;
using System.Text.Json;

public class User
{
    private int _points;
    private string _username;
    private List<string> _goalList = new List<string>();
    private string _filePath;
    private string _directoryPath;

    public User(string username)
    {
        _username = username;
        
    }

    public void AddToList(string goal)
    {
        _goalList.Add(goal);
    }

    public void SaveToFile()
    {
        _directoryPath = $"SaveData/{_username}";
        _filePath = $"{_directoryPath}/Goals.txt";

        Directory.CreateDirectory(_directoryPath);

        using (StreamWriter outputFile = new StreamWriter(_filePath))
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
    }



}