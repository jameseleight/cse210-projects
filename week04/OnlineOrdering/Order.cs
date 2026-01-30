using System;
using System.Numerics;
using System.Runtime.CompilerServices;
public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    // Constructors
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        // Add to the list
        _products.Add(product);
    }
    // Methods for Order Class
    public string OrderTotal()
    {
        // generate total cost before shipping
        float subTotal = 0;
        foreach (var item in _products)
        {
        subTotal += item.TotalPrice();            
        }
        if (_customer.LiveInUSA())
        {
            subTotal += 5;
        }
        else
        {
            subTotal += 35;
        }
        return $"${subTotal.ToString("F2")}";
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label");
        foreach (var item in _products)
        {
            item.DisplayNameID();
        }
        Console.WriteLine();
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        _customer.DisplayNameAddress();
        Console.WriteLine();
    }
}