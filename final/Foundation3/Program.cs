using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        string a = "f";
        int a1 = 5;
        string b = "f";
        string c = "f";
        string d = "f";
        string e = "f";
        string f = "f";

        List<Event> events = new List<Event>();
        
        Lecture lecture = new Lecture(a, a1, b, c, d, e, f);

        events.Add(lecture);

        foreach (var item in events) {
            item.FullDetails();
        }
    }
}