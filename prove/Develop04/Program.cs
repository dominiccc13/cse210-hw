using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        string varCase = "";
        while (varCase != "quit") {
            Console.Clear();
            System.Console.WriteLine("Menu Options:");
            System.Console.WriteLine("\t1. Breathing Activity");
            System.Console.WriteLine("\t2. Reflection Activity");
            System.Console.WriteLine("\t3. Listing Activity");
            System.Console.WriteLine("\t4. Quit");
            System.Console.Write("Select a choice from the menu: ");
            varCase = Console.ReadLine();
            
            switch (varCase) {
                case "1" or "1.":
                    int desc = 0;
                    var breathing = new BreathingActivity("breathing", desc);
                    breathing.StartActivity();
                    breathing.RunBreathingActivity();
                    breathing.ConcludeActivity();
                    break;
                case "2" or "2.":
                    desc = 1;
                    var reflection = new ReflectionActivity("reflection", desc);
                    reflection.StartActivity();
                    reflection.RunReflectionActivity();
                    reflection.ConcludeActivity();
                    break;
                case "3" or "3.":
                    desc = 2;
                    var listing = new ListingActivity("listing", desc);
                    listing.StartActivity();
                    listing.RunListingActivity();
                    listing.ConcludeActivity();
                    break;
                default:
                    varCase = "quit";
                    break;
            } 
        }
    }
}