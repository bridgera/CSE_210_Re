using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;
    public OutdoorGathering(string title, string description, string date, string time, string weatherForecast) : base(title, description, date, time)
    {
        _type = "Outdoor Gathering";
        _weatherForecast = weatherForecast;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine("\nFULL DETAILS:");
        Console.WriteLine($"{_title} | {_description} | {_date} @{_time} | {_address.AddressString()} | {_weatherForecast}");
    }
}

