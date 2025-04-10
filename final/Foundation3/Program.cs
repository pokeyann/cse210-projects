using System;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address address1 = new Address("105 Center St", "Heber City", "UT", "USA");
        Address address2 = new Address("SW1A 1A", "London", "England", "UK");
        Address address3 = new Address("123", "Weifang City", "Shangdong Province", "China");

        Lecture lecture = new Lecture("At Home Cook", "Learn the basics to cooking from scratch.", new DateTime(2025, 5, 1), new TimeSpan(15, 30, 0), address1, "Boba Ganoosh", 100);

        Reception reception = new Reception("Sleep Convention", "Come and nap with us and learn healthy sleeping habits", new DateTime(2025, 6, 15), new TimeSpan(12, 0, 0), address2, "rsvp@sleepcon.com");

        Outdoor outdoor = new Outdoor("Kite Festival", "Let's go fly a kite!", new DateTime(2025, 8, 9), new TimeSpan(9, 0, 0), address3, "Partly Cloudy with a high of 75F");

        DisplayEventDetails(lecture);
        DisplayEventDetails(reception);
        DisplayEventDetails(outdoor);
    }

    static void DisplayEventDetails(BaseEvent eventItem)
    {
        Console.WriteLine();
        Console.WriteLine(eventItem.GetStandardDetails());
        Console.WriteLine(eventItem.GetFullDetails());
        Console.WriteLine(eventItem.GetShortDescription());
    }
}