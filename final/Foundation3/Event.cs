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
    
    public string GetFullAddress()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}


public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }
    
    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }
    
    public virtual string GetStandardDetails()
    {
        return $"{Title} - {Description}\nDate: {Date} Time: {Time}\nAddress: {Address.GetFullAddress()}";
    }
    
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
    
    public virtual string GetShortDescription()
    {
        return $"{Title} - {Date} {Time}";
    }
}

