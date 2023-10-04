using System;
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public string Display()
    {
        string jobinfo = ($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        Console.WriteLine(jobinfo);
        return null;
    }
}