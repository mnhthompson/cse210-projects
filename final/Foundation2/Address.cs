using System;

public class Address

{

///The address contains a string for the street address, the city, state/province, and country.

private string _streetAddress;

private string _city;

private string _state;

private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

///The address should have a method that can return whether it is in the USA or not.

 public bool IsAmerican()

{
    return _country == "USA" ? true : false;
}

/// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
/// 

public string MakeAdress()

{

      string address = _streetAddress + ", " + _city + "\n" + _state + ", " + _country;
        return address;
}


}