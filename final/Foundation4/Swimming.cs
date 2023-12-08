class Swimming : Activity
{
    private double _laps;
    private string _type = "Swimming";

    public Swimming(double laps, string date, double duration) : base(date, duration) {
        _laps = laps;
    }
    public override double GetDistance() {
        double meters = _laps * 50;
        double miles = meters / 1609.34;
        return miles;
    }
    public override double GetSpeed() {
        double hours = _duration / 60;
        double speed = this.GetDistance() / hours;
        return speed;
    }
    public override double GetPace() {
        double pace = _duration / this.GetDistance();
        return pace;
    }
    public override string GetType() {
        return _type;
    }
}