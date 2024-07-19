public class Reception : Event
{
    public string Email { get; set; }
    
    public Reception(string title, string description, string date, string time, Address address, string email)
        : base(title, description, date, time, address)
    {
        Email = email;
    }
    
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP: {Email}";
    }
}