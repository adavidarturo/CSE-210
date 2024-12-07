using System;
class Program
{
    static void Main(string[] args)
    {
        // Address 
        Address address1 = new Address("Alamos de Cayma Mz. X-12B", "Arequipa", "Arequipa", "Peru");
        Address address2 = new Address("321 Main St", "Denver", "Colorado", "USA");

        // Customers
        Customer customer1 = new Customer("David Anampa", address1);
        Customer customer2 = new Customer("Felix Villegas", address2);

        // Products
        Product product1 = new Product("Laptop", "A123", 399.99, 1);
        Product product2 = new Product("Piano", "B123", 499.99, 2);
        Product product3 = new Product("Washing Machine", "C123", 399.99, 1);

        // Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product3);

        // Display Orders information
        Console.WriteLine("\n--------------------------------------------\n");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\n--------------------------------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");

        Console.WriteLine("\n--------------------------------------------\n");
    }
}



