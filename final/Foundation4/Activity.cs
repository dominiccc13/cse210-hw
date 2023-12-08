abstract class Activity
{
    protected string _date;
    protected double _duration;
    private string _type;

    public Activity(string date, double duration) {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance() {
        return 0.0;
    }
    public virtual double GetSpeed() {
        return 0.0;
    }
    public virtual double GetPace() {
        return 0.0;
    }
    public virtual string GetType() {
        return "nothing";
    }
    public virtual void Summary() {
        System.Console.WriteLine($"{_date} {this.GetType()} ({_duration} min)- Distance {this.GetDistance()} miles, Speed {this.GetSpeed()} mph, Pace {this.GetPace()} min per mile");
    }
}
