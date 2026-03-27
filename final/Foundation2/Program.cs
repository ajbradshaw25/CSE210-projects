using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: Domestic (USA)
        Address addr1 = new Address("123 Maple St", "Seattle", "WA", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "L404", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M202", 25.50, 2));

        // Order 2: International
        Address addr2 = new Address("456 Rue de Rivoli", "Paris", "IDF", "France");
        Customer cust2 = new Customer("Jean-Luc Picard", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Coffee Mug", "C101", 12.00, 3));
        order2.AddProduct(new Product("Tea Kettle", "K909", 45.00, 1));

        DisplayOrderInfo(order1);
        DisplayOrderInfo(order2);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order.CalculateTotal():0.00}");
        Console.WriteLine("----------------------------------\n");
    }
}
