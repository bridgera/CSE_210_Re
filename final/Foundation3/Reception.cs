using System;

public class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string title, string description, string date, string time, string rsvpEmail) : base(title, description, date, time)
    {
        _type = "Reception";
        _rsvpEmail = rsvpEmail;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("\nFULL DETAILS:");
        Console.WriteLine($"{_title} | {_description} | {_date} @{_time} | {_address.AddressString()} | {_rsvpEmail}");
    }
}