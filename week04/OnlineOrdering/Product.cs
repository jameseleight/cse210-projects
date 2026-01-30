using System;
public class Product
{
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;
    // Constructors
    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _id = productId;
        _price = price;
        _quantity = quantity;
    }
    // Methods for Product Class
    public float TotalPrice()
    {
        // Compute the total price and return the float value
        return _price * _quantity;
    }
    public void DisplayNameID()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"ID: {_id}");
    }
}