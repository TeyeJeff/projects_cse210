using System;

class Program
{
    static void Main(string[] args)
    {
       // Create first customer (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create products for first order
        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "P001", 999.99m, 1),
            new Product("Mouse", "P002", 29.99m, 2),
            new Product("Keyboard", "P003", 59.99m, 1)
        };

        // Create first order
        Order order1 = new Order(customer1, products1);

        // Create second customer (International)
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products for second order
        List<Product> products2 = new List<Product>
        {
            new Product("Headphones", "P004", 89.99m, 3),
            new Product("Webcam", "P005", 49.99m, 1)
        };

        // Create second order
        Order order2 = new Order(customer2, products2);

        // Display results for first order
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine("----------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\n" + order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        // Display results for second order
        Console.WriteLine("Order 2 Details:");
        Console.WriteLine("----------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\n" + order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.GetTotalCost():F2}"); 
    }
}