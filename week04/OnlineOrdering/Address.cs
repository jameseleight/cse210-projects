using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zip;
    private string _country;
    // Constructors
    public Address(string street, string city, string state, string zip, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }
    // Methods for Address Class
    public bool InUSA()
    {
        // Check if in USA and return the result
        return _country == "USA";
    }
    public string FormattedAddress()
    {
        // Format the Mailing Address
        return $"{_streetAddress}{Environment.NewLine}{_city}, {_state}  {_zip}{Environment.NewLine}{_country}{Environment.NewLine}";
    }    
}