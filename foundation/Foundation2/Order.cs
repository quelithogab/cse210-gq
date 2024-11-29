using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order()
    {
       
    }

    public decimal CalculateTotalCost()
    {
       
    }

    public string GetPackingLabel()
    {
        
    }

    public string GetShippingLabel()
    {
       
    }
}
