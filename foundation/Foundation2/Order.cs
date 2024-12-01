using System.Collections.Generic;

public class Order
{
    private List<Product> _products; // List of Products
    private Customer _customer; // Custumer data

    // Constructor to initialize all "Order" variables
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }
    
    // Method to add products to the "_products" list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to optain the final cost of the product
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products) // For each product in the list
        {
            totalCost += product.GetTotalPrice(); // Increase the "totalCoast" 
        }
        if (_customer.IsInUSA()) // If it's in the USA
        {
            totalCost += 5;
        }
        else // If it's outside
        {
            totalCost += 35;
        }
        return totalCost;
    }

    // Method to optain each product name and ID
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products) // For each product in the list
        {
            // Get each Product name, ID and Quantity
            label += $"{product.GetProductName()} (ID: {product.GetProductId()}) - Quantity: {product.GetQuantity()}\n";
        }
        return label;
    }
    
    // Method to optain the person's name, address list and full address
    public string GetShippingLabel()
    {
        string label = $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        return label;
    }
}



