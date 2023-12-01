using System.Runtime.CompilerServices;

abstract class Goal 
{
    protected string _name;
    protected string _desc;
    protected int _points;
    protected int _totalPoints;
    protected bool _status;

    public abstract void NewGoal(string name, string desc, int points, bool status=false, int completionsRequired=0, int bonusPoints=0);
    public virtual void UpdateStatus(bool status=false) {
        _status = status;
    }
    public abstract void RecordEvent();
    public virtual int GetTimesCompleted() {
        int doNothing = 0;
        return doNothing;
    }
    public virtual int GetCompletionsRequired() {
        int doNothing = 0;
        return doNothing;
    }
    public string GetName() {
        return _name;
    }
    public bool GetStatus() {
        return _status;
    }
    public int GetPoints() {
        return this._totalPoints;
    }
    public static int DisplayGoals(List<Goal> goals) {
        int i = 1;
        int totalPoints = 0;
        foreach (Goal item in goals) {
            string name = item.GetName();
            bool status = item.GetStatus();
            string statusString = status ? "[x]" : "[ ]";  
            if (item is ChecklistGoal) {
                Console.Write($"{i}. {name} {statusString} ");
                int timesCompleted = item.GetTimesCompleted();
                int completionsRequired = item.GetCompletionsRequired();
                System.Console.WriteLine($"Completed {timesCompleted}/{completionsRequired} times");
            } else {System.Console.WriteLine($"{i}. {name} {statusString}");}
            totalPoints += item.GetPoints();
            i++;
        }
        return totalPoints;
        // System.Console.WriteLine($"Total points: {totalPoints}");
    }
}