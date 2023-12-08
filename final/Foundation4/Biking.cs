class Biking : Activity
{
    private double _speed;
    private string _type = "Biking";

    public Biking(double speed, string date, double duration) : base(date, duration) {
        _speed = speed;
    }
    public override double GetDistance() {
        double hours = _duration / 60;
        double distance = _speed * hours;
        return distance;
    }
    public override double GetSpeed() {
        return _speed;
    }
    public override double GetPace() {
        double pace = _duration / this.GetDistance();
        return pace;
    }
    public override string GetType() {
        return _type;
    }
}