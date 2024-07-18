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
