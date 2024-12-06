// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
    
        Address address1 = new Address("1428 Elm St", "Springwood", "OH", "USA");
        Address address2 = new Address("237 North Hyde", "Crescent", "BC", "Canada");

        
        Customer customer1 = new Customer("Freddy Kruger", address1);
        Customer customer2 = new Customer("John Kramer", address2);

      
        Product product1 = new Product("Laptop", 101, 1000, 2);
        Product product2 = new Product("Mouse", 102, 25, 3);
        Product product3 = new Product("Keyboard", 103, 50, 1);

       
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

       
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product1);

       
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());
    }
}
