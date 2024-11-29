using System;

class Program
{
    static void Main(string[] args)
    {
        // The customers
        var customer1 = new Customer
        {
            Name = "Blanc Atkingson",
            Address = new Address
            {
                Street = "123 Maple St",
                City = "Springfield",
                State = "IL",
                Country = "USA"
            }
        };

        var customer2 = new Customer
        {
            Name = "Delva Ricardo",
            Address = new Address
            {
                Street = "456 Elm St",
                City = "Toronto",
                State = "ON",
                Country = "Canada"
            }
        };

        // The products
        var product1 = new Product { Name = "Laptop", ProductID = "A123", Price = 2500, Quantity = 1 };
        var product2 = new Product { Name = "Mouse", ProductID = "B456", Price = 15, Quantity = 2 };
        var product3 = new Product { Name = "Speaker", ProductID = "C789", Price = 250, Quantity = 4 };
        var product4 = new Product { Name = "Camera", ProductID = "D012", Price = 500, Quantity = 1 };

        // Create orders
        var order1 = new Order { Customer = customer1 };
        order1.Products.Add(product1);
        order1.Products.Add(product2);

        var order2 = new Order { Customer = customer2 };
        order2.Products.Add(product3);
        order2.Products.Add(product4);

        // Order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");

    }
}
