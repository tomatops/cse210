public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Sets values of member variables
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Returns whether the country is in USA or not
    public bool IsUSA()
    {
        return _country == "USA";
    }

    // Returns the full address as a string
    public string GetAddress()
    {
        return $@"{_street}
        {_city}, {_state}
        {_country}";
    }
}