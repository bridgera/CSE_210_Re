using System;

public class Costumer
{
    private string _name;
    private Address _address;


    public Costumer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsInUS()
    {
        return _address.IsInUS();
    }

    public string GetAddressString()
    {
        return _address.AddressString();
    }
}
