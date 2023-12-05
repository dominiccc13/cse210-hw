abstract class Event
{
    protected string _title;
    protected string _desc;
    protected string _date;
    protected string _time;
    protected string _address;
    public Event(string title, string desc, string date, string time, string address) {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }
    public void StandardDetails() {
        System.Console.WriteLine($"Title: {this._title}");
        System.Console.WriteLine($"Description: {this._desc}");
        System.Console.WriteLine($"Date: {this._date}");
        System.Console.WriteLine($"Time: {this._time}");
        System.Console.WriteLine($"Address: {this._address}");
    }
    public abstract void FullDetails();
    //     public void FullDetails() {
    //     System.Console.WriteLine($"Title: {this._title}");
    //     System.Console.WriteLine($"Description: {this._desc}");
    //     System.Console.WriteLine($"Date: {this._date}");
    //     System.Console.WriteLine($"Time: {this._time}");
    //     System.Console.WriteLine($"Address: {this._address}");
    // }
    // public string GetType() {
    //     return this._type;
    // }
}