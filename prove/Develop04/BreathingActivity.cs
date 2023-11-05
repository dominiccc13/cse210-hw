class BreathingActivity : Activity 
{ 
    public BreathingActivity(string activityName, int descIndex) : base(activityName, descIndex) {
    }

    public void RunBreathingActivity() {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this._duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime) {
            System.Console.WriteLine();
            System.Console.Write("Breathe in     ");
            ShowAnimation("countdown", 4);
            System.Console.Write("Breathe out     ");
            ShowAnimation("countdown", 6);
            currentTime = DateTime.Now;
        }
    }
}