using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("177A 5th Avenue", "New York City", "NY", "10001");
        Address receptionAddress = new Address("12 Ocean Avenue", "Narragansett", "RI", "02882");
        Address outdoorAddress = new Address("10700 W. Escondido Canyon Road", "Santa Clarita", "CA", "91390");

        Lecture lecture = new Lecture("Glorious Purpose", "A lecture of invasion tactics", "2012-04-26", "10:00 AM", lectureAddress, "Loki Laufeyson", 200);
        Reception reception = new Reception("Earth's Mightiest Heroes", "A gathering to discuss the looming alien threat", "1960-02-06", "5:00 PM", receptionAddress, "RSVP at preptime@wayneindustries.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic at the Park", "A fun outdoor gathering in the park, where nothing will go wrong.", "1997-08-29", "1:00 PM", outdoorAddress, "Sunny, Mushroom clouds, Approx 2000°C");

        DisplayEventDetails(lecture);
        DisplayEventDetails(reception);
        DisplayEventDetails(outdoorGathering);
    }

    static void DisplayEventDetails(Event eventObj)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(eventObj.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(eventObj.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(eventObj.GetShortDescription());
        Console.WriteLine("-------------------------------------------------");
    }
}
