class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MOU456", 19.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "KEY789", 49.99, 1));
        order2.AddProduct(new Product("Monitor", "MON012", 199.99, 1));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
            Console.WriteLine();
        }
    }
}
