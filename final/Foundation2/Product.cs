public class Product
{
    public string Name { get; set; }
    public string ProductId { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    
    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }
    
    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    
    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }
    
    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }
    
    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}

public class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }
    
    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }
    
    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }
}

public class Order
{
    private List<Product> Products { get; set; }
    private Customer Customer { get; set; }
    
    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }
    
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    
    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.GetTotalCost();
        }
        if (Customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    
    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in Products)
        {
            packingLabel.AppendLine($"{product.Name} ({product.ProductId})");
        }
        return packingLabel.ToString();
    }
    
    public string GetShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}
