using System;

class Program
{
    static void Main(string[] args)
    {
        // The customers
        var customer1 = new Customer
        {
            
        };

        var customer2 = new Customer
        {
           
        };

        // Create the product
        var product1 = new Product { Name = "Laptop", ProductID = "A123", Price = 1000, Quantity = 1 };
       

        // Create the order
        var order1 = new Order { Customer = customer1 };
        order1.Products.Add(product1);
        order1.Products.Add(product2);

      
        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}\n");

    }
}
