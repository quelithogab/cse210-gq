using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public List<Product> Products { get => _products; set => _products = value; }
    public Customer Customer { get => _customer; set => _customer = value; }

    public Order()
    {
        _products = new List<Product>();
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        var label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductID})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.Address.GetFullAddress()}";
    }
}
