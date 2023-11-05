class Activity 
{
    protected int _duration;
    private string _activityName;
    protected string _description;
    
    public Activity(string activityName, int descIndex) {
        List<string> descriptions = new List<string>();
        descriptions.Add("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        descriptions.Add("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        descriptions.Add("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        _activityName = activityName;
        _description = descriptions[descIndex];
    }

    public void ConcludeActivity() {
        System.Console.WriteLine();
        System.Console.WriteLine($"Good job! You have completed the {this._activityName} activity.");
        System.Console.WriteLine();
        Thread.Sleep(1000);
        System.Console.WriteLine($"You performed the {this._activityName} activity for {this._duration} seconds.");
        System.Console.WriteLine();
        Thread.Sleep(3000);
    }

    public void StartActivity() {
        Console.Clear();
        System.Console.WriteLine();
        System.Console.WriteLine($"Welcome to the {this._activityName} activity!");
        System.Console.WriteLine();
        System.Console.WriteLine($"{this._description}.");
        System.Console.WriteLine();
        System.Console.Write($"How long would you like to run the {this._activityName} activity? ");

        _duration = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine();
        System.Console.Write($"The {this._activityName} activity will begin in     ");
        ShowAnimation("countdown", 3);
    }

    public static void ShowAnimation(string type, int duration) {
        switch (type) {
            case "countdown":
                for (int sec = duration; sec>0; sec--) {
                    // Console.Write("\b\b\b\b    ");
                    Console.Write($"\b\b\b\b{sec}...");
                    Thread.Sleep(1000);
                }
                Console.Write($"\b\b\b\b{0}...");
                // Console.Write("\b\b\b\b    ");
                // Console.Write("\b\b\b\b");
                Console.WriteLine();

                break;
            case "spinner":
                int animation = 0;
                while (animation < duration) {
                    Console.Write("\b\b\b\b    ");
                    Console.Write("\b\b\b\b");
                    Console.Write("|");
                    Thread.Sleep(500);
                    Console.Write("\b/");
                    Thread.Sleep(500);
                    Console.Write("\b-");
                    Thread.Sleep(500);
                    Console.Write("\b\\");
                    Thread.Sleep(500);
                    animation++;
                }
                Console.Write("\b");
    
                break;
            case "periods":
                // Console.Write("\b");
                animation = 0; 
                while (animation < 5) {
                    Console.Write("\b\b\b   ");
                    Console.Write("\b\b\b.");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    animation++;
                }
                Console.Write("\b\b\b   ");

                break;
        }
    }
}