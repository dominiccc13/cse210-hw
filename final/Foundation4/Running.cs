using System.IO.Pipes;

class Running : Activity
{
    private double _distance;
    private string _type = "Running";

    public Running(double distance, string date, double duration) : base(date, duration) {
        _distance = distance;
    } 
    public override double GetDistance() {
        return _distance;
    }
    public override double GetSpeed() {
        double hours = _duration / 60;
        double speed = _distance / _duration;
        return speed;
    }
    public override double GetPace() {
        double pace = _duration / _distance;
        return pace;
    }
    public override string GetType() {
        return _type;
    }
}