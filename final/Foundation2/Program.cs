using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("123 Center St.", "Heber City", "UT", "USA");
        Address address2 = new Address("765 W Sherman", "Edinburgh", "Scotland", "UK");

        Customer customer1 = new Customer("Boba Ganoosh", address1);
        Customer customer2 = new Customer("Silly Goose", address2);

        Product product1 = new Product("Tiny Hands", "TH5", 9.99, 5);
        Product product2 = new Product("Magnetic Cord Holder", "MCH1976", 15.99, 3);
        Product product3 = new Product("Highland Cow Print", "Moo2006", 35, 1);
        Product product4 = new Product("GoldenDoodle Puppy", "CUTE3000", 2000, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product4);

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine();
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: {order.TotalCost(): 0.00}");
        Console.WriteLine();
    }
    
}