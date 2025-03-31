public class Program
{
    public static void Main()
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Springfield", "IL", "USA");
        Address canadaAddress = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer canadaCustomer = new Customer("Jane Smith", canadaAddress);

        // Create products
        Product product1 = new Product("Widget", "W123", 10m, 2);
        Product product2 = new Product("Gadget", "G456", 15m, 1);
        Product product3 = new Product("Thingamajig", "T789", 20m, 3);
        Product product4 = new Product("Doodad", "D012", 5m, 4);

        // Create orders
        Order order1 = new Order(new List<Product> { product1, product2 }, usaCustomer);
        Order order2 = new Order(new List<Product> { product3, product4 }, canadaCustomer);

        // Display order details
        DisplayOrderDetails(order1, "Order 1");
        DisplayOrderDetails(order2, "Order 2");
    }

    private static void DisplayOrderDetails(Order order, string orderLabel)
    {
        Console.WriteLine($"{orderLabel} Packing Label:");
        Console.WriteLine(order.GeneratePackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GenerateShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order.CalculateTotalCost():0.00}\n");
    }
}