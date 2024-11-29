public class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }
}
