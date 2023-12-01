using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, string speaker, int capacity) : base(title, description, date, time)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("\nFULL DETAILS:");
        Console.WriteLine($"{_title} | {_description} | {_date} @{_time} | {_address.AddressString()} | {_speaker} | {_capacity}");
    }
}
