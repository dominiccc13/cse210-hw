class ListingActivity : Activity 
{
    public ListingActivity(string activityName, int descIndex) : base(activityName, descIndex) {
    }

    public void RunListingActivity() {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this._duration);
        // endTime = endTime.AddSeconds(3);
        DateTime currentTime = DateTime.Now;

        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        Random rnd = new Random();
        int promptsIndex = rnd.Next(0,5);
        string prompt = prompts[promptsIndex];

        System.Console.WriteLine();
        System.Console.WriteLine(prompt);
        System.Console.WriteLine();
        System.Console.WriteLine("You will have 3 seconds to think about this before you begin typing.");
        System.Console.WriteLine();
        Thread.Sleep(3000);
        System.Console.WriteLine("Begin typing!");
        System.Console.WriteLine();

        List<string> entries = new List<string>();

        while (currentTime < endTime) {
            string entry = Console.ReadLine();
            System.Console.WriteLine();
            entries.Add(entry);
            currentTime = DateTime.Now;
        }

        if (entries.Count == 1) {
            System.Console.WriteLine("You provided 1 response.");
        }
        else {
            System.Console.WriteLine($"You provided {entries.Count} responses.");
        }
    }
}