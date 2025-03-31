public class Address
{
    private readonly string _street;
    private readonly string _city;
    private readonly string _state;
    private readonly string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA() => _country.Equals("USA", StringComparison.OrdinalIgnoreCase);

    public string GetFullAddress() => $"{_street}\n{_city}, {_state}\n{_country}";
}
