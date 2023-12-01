using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _type;
    protected Address _address;



    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _address = new Address(street, city, state, country);
    }

    public void GetStandardDetails()
    {
        Console.WriteLine("\nSTANDARD DETAILS:");
        Console.WriteLine($"{_title} | {_description} | {_date} @{_time} | {_address.AddressString()}");
    }

    public virtual void GetFullDetails()
    {
        Console.WriteLine("\nFULL DETAILS:");
    }

    public void GetShortDes()
    {
        Console.WriteLine("\nSHORT DESCRIPTION:");
        Console.WriteLine($"{_type} | {_title} | {_date}");
    }
    
}