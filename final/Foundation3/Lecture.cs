class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lecture(string speaker, int maxCapacity, string title, string desc, string date, string time, Address address) : 
    base(title, desc, date, time, address) {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }
    public override void FullDetails() {
        System.Console.WriteLine($"\tTitle: {this._title}");
        System.Console.WriteLine($"\tDescription: {this._desc}");
        System.Console.WriteLine($"\tDate: {this._date}");
        System.Console.WriteLine($"\tTime: {this._time}");
        System.Console.WriteLine($"\tAddress: {this._address}");
        System.Console.WriteLine($"\tType: {this._type}");

        System.Console.WriteLine($"\tSpeaker: {this._speaker}");
        System.Console.WriteLine($"\tMax Capacity: {this._maxCapacity}");
    }
    public override void SetType() {
        _type = "Lecture";
    }
}