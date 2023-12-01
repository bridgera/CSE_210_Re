using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _inUS;


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUS()
    {
        if (_country == "US")
        {
            _inUS = true;
        }
        else
        {
            _inUS = false;
        }

        return _inUS;  
    }

    public string AddressString()
    {
        return $"{_street}\n{_city}, {_state}, {_country}";
    }
}