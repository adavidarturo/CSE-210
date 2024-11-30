public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country; 

    // Constructor to initialize all "Address" variables 
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Bool Method check if it's or not in USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Method to optain the complete address
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}


