public class Product
{
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public string Name { get => _name; set => _name = value; }
    public string ProductID { get => _productID; set => _productID = value; }
    public decimal Price { get => _price; set => _price = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}
