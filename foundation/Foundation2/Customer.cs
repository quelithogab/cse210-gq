public class Customer
{
    private string _name;
    private Address _address;

    public string Name { get => _name; set => _name = value; }
    public Address Address { get => _address; set => _address = value; }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}
