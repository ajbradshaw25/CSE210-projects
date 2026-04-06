using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address addr1 = new Address("275 Pico Lane", "San Francisco", "UT", "58623");
        Address addr2 = new Address("456 Gala Ct", "New York", "NY", "10841");
        Address addr3 = new Address("789 Park Blvd", "Austin", "TX", "73271");

        List<Event> events = new List<Event>
        {
            new Lecture("Psychology in Action", "A deep dive into neural networks of the brain.", "Oct 10, 2024", "10:00 AM", addr1, "Dr. Smith", 200),
            new Reception("Networking Mixer", "Meet and greet with industry leaders.", "Oct 11, 2024", "2:00 PM", addr2, "rsvp@events.com"),
            new OutdoorGathering("Desert Trip", "Food, offroading, and fun for the family.", "Oct 12, 2024", "6:00 PM", addr3, "Sunny with a light breeze.")
        };

        foreach (var ev in events)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\nFULL DETAILS:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\nSHORT DESCRIPTION:");
            Console.WriteLine(ev.GetShortDescription());
        }
    }
}
