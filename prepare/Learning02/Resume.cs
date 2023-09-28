using System;
using System.Collections.Generic;

public class Resume
{
    public string _userName;
    public List<Job> _jobList = new List<Job>();

    public string Display()
    {
        Console.WriteLine($"Name: {_userName}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _jobList)
        {
           job.Display();
        }
        return null;
    }
}