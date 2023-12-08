using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        Activity running = new Running(3, "12/07/2023", 20);
        Activity biking = new Biking(20, "12/07/2023", 70);
        Activity swimming = new Swimming(20, "12/07/2023", 60);

        activities.Add(running);
        activities.Add(biking);
        activities.Add(swimming);

        int i = 0;
        foreach (Activity activity in activities) {
            i++;
            System.Console.WriteLine($"Activity {i}:");
            activity.Summary();
            System.Console.WriteLine();
        }
    }
}