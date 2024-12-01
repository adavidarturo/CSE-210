public class Customer
{
    private string _name;
    private Address _address; // Person's full address

    // Constructor to initialize variables
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to get the person's _name
    public string GetName()
    {
        return _name;
    }

    // Method to get the _address list
    public Address GetAddress()
    {
        return _address;
    }

    // Method to verify if the person lives in USA
    public bool IsInUSA()
    {
        return _address.IsInUSA(); // Save the IsInUSA() method from "Address"
    }
}



