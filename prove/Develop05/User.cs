using System;
using System.Dynamic;

public class User
{
    private int _points;
    private string _username;

    public User(string username, int points=0)
    {
        _username = username;
        _points = points;

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