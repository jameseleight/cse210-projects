using System;
public class Customer
{
    private string _name;
    private Address _address;
    // Constructors
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    // Methods for Customer Class
    public bool LiveInUSA()
    {
        // Customer lives in USA
        return _address.InUSA();
    }
    public void DisplayNameAddress()
    {
        Console.WriteLine(_name);
        Console.Write(_address.FormattedAddress());
    }
}