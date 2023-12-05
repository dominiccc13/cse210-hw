class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lecture(string speaker, int maxCapacity, string title, string desc, string date, string time, string address) : 
    base(title, desc, date, time, address) {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }
    public override void FullDetails() {
        System.Console.WriteLine($"Title: {this._title}");
        System.Console.WriteLine($"Description: {this._desc}");
        System.Console.WriteLine($"Date: {this._date}");
        System.Console.WriteLine($"Time: {this._time}");
        System.Console.WriteLine($"Address: {this._address}");
        System.Console.WriteLine($"Speaker: {this._speaker}");
        System.Console.WriteLine($"Max Capacity: {this._maxCapacity}");
    }
}