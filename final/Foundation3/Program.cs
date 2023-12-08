using System;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        
        Address lectureAddress = new Address("Newel K. Whitney's Store", "Kirtland", "OH");
        Address receptionAddress = new Address("111 South 1st St", "Draper", "UT");
        Address outdoorAddress = new Address("1355 N 2nd E", "Rexburg", "ID");

        Event lecture = new Lecture("Sidney Rigdon", 50, "Lecture 1", "Provide a theological lecture on faith", "01//15/1833", "7:00 AM", lectureAddress);
        Event reception = new Reception("ste21075@byui.edu", "The Sunnies", "End of the year party", "12/02/2023", "6:00 PM", receptionAddress);
        Event outdoor = new Outdoor("Clear", "Temple Dedication", "The Rexburg North (Teton River) temple will be dedicated", "TBD", "Morning", outdoorAddress);
        
        events.Add(lecture);
        events.Add(reception);
        events.Add(outdoor);

        int i = 0;
        foreach (var item in events) {
            i++;
            item.SetType();
            System.Console.WriteLine($"\nEvent {i}:");
            System.Console.WriteLine("Full details:");
            item.FullDetails();
            System.Console.WriteLine("\nStandard details:");
            item.StandardDetails();
            System.Console.WriteLine("\nShort description:");
            item.ShortDescription();
        }
    }
}