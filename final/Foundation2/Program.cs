using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        RunOrderSystem();
    }

    static void RunOrderSystem()
    {
        Customer customer1 = GetCustomer("John Doe", "123 Main St", "Rexburg", "Idaho", "America");
        Product product1 = new Product("Product1", 1, 10.99f, 2);
        Product product2 = new Product("Product2", 2, 5.99f, 3);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Customer customer2 = GetCustomer("Jane Smith", "456 Oak St", "Los Angeles", "California", "USA");
        Product product3 = new Product("Product3", 3, 8.49f, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Customer customer3 = GetCustomer("Li Lou", "555 North St", "Florence", "NA", "Italy");
        Product product4 = new Product("Product4", 3, 8.49f, 4);
        Order order3 = new Order(customer3);
        order3.AddProduct(product4);

        DisplayOrder(order1);
        DisplayOrder(order2);
        DisplayOrder(order3);
    }

    static Customer GetCustomer(string name, string street, string city, string state, string country)
    {
        Address address = new Address(street, city, state, country);
        return new Customer(name, address);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine($"Total Price: {order.TotalPrice()}\n");
    }
}