public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor to initialize all "Product" variables 
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    
    // Method to multiplay price by quantity
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
    
    // Method to optain the product name
    public string GetProductName()
    {
        return _name;
    }

    // Method to optain the quantity value
    public int GetQuantity()
    {
        return _quantity;
    }

    // Method to display all Product information
    public string Display()
    {
        return $"{_name} (ID: {_productId}) -  Quantity: {_quantity}";
    }
}


