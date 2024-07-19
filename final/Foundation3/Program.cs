using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Elsewhere", "CA", "USA");

        Lecture lecture = new Lecture("Tech Talk", "An in-depth look at AI", "2024-08-01", "10:00 AM", address1, "John Doe", 100);
        Reception reception = new Reception("Company Mixer", "Networking event for local businesses", "2024-08-05", "6:00 PM", address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "Annual neighborhood picnic", "2024-08-10", "12:00 PM", address3, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (var eventItem in events)
        {
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine();
        }
    }
}
