using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order()
    {
        Products = new List<Product>();
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }

        total += Customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        var label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name} (ID: {product.ProductID})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}
