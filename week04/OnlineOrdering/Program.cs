using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        Address address1 = new Address("1730 Elm Ave", "Torrance", "CA", "90503", "USA");
        Customer customer1 = new Customer("James Leight", address1);
        Order order1 = new Order(customer1);
        Product product1a = new Product("Basketball", "12377", 27.95f, 4); order1.AddProduct(product1a);
        Product product1b = new Product("Baseball", "12379", 17.76f, 12); order1.AddProduct(product1b);
        Product product1c = new Product("Volleyball", "12381", 18.14f, 9); order1.AddProduct(product1c);

        Address address2 = new Address("25668 Cape Coast Road", "Cape Coast", "Liberty", "", "Ghana");
        Customer customer2 = new Customer("Jim Leight", address2);
        Order order2 = new Order(customer2);
        Product product2a = new Product("Soccer Ball", "12277", 19.15f, 20); order2.AddProduct(product2a);
        Product product2b = new Product("Soccer Goal", "12279", 176.66f, 4); order2.AddProduct(product2b);
        Product product2c = new Product("Shin Guards", "12281", 8.65f, 40); order2.AddProduct(product2c);

        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine($"The Order Total is: {order1.OrderTotal()}");
        Console.WriteLine();

        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine($"The Order Total is: {order2.OrderTotal()}");
        Console.WriteLine();

        Console.WriteLine("Thank you for using the online ordering program!");

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Online Ordering Program!");
        Console.WriteLine();
    }
}