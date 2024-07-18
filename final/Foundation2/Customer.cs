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
