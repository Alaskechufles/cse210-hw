using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // Create addresses
        Address address1 = new Address("123 Orange St", "New York", "New York", "USA");
        Address address2 = new Address("456 Pear St", "Camaná", "Arequipa", "Perú");

        // Create customers
        Customer customer1 = new Customer("Diego Huarsaya", address1);
        Customer customer2 = new Customer("Sigrid Berlanga", address2);

        // Create products
        Product product1 = new Product("Piano", "001", 100, 1);
        Product product2 = new Product("Guitar", "002", 120, 2);
        Product product3 = new Product("Flute", "003", 130, 1);
        Product product4 = new Product("Drum", "004", 140, 2);
        Product product5 = new Product("Maraca", "005", 150, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateCost():0.00}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateCost():0.00}");
    }
}