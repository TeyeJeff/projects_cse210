using System;

class Program
{
    static void Main(string[] args)
    {
       //usa customer
        Address address1 = new Address("73 Avenue St", "Chicago", "Ch", "USA");
        Customer customer1 = new Customer("Solomon Sekyere", address1);

        
        List<Product> products1 = new List<Product>
        {
            new Product("Playstation 5", "P001", 652.79m, 1),
            new Product("EA sport 25", "P002", 69.99m, 2),
            new Product("PS VR", "P003", 80.99m, 1)
        };

        // Creating first order
        Order order1 = new Order(customer1, products1);

        // Creating second customer (International)
        Address address2 = new Address("45th Street Accra", "Accra", "GA", "Ghana");
        Customer customer2 = new Customer("Irene Appiah", address2);

        // Creating products for second order
        List<Product> products2 = new List<Product>
        {
            new Product("Shirts", "P004", 25.99m, 3),
            new Product("Adidas Sabalo", "P005", 205.99m, 1)
        };

        // Creating second order
        Order order2 = new Order(customer2, products2);

        // Displaying 1st order
        Console.WriteLine("1st Order Details:");
        Console.WriteLine("----------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\n" + order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        // Displaying 2nd order
        Console.WriteLine("2nd Order Details:");
        Console.WriteLine("----------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\n" + order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.GetTotalCost():F2}"); 
    }
}