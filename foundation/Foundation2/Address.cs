public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public bool IsInHaiti()
    {
        return Country.ToUpper() == "Haiti";
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}
