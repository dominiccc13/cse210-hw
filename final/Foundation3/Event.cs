abstract class Event
{
    protected string _title;
    protected string _desc;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _type;

    public Event(string title, string desc, string date, string time, Address address) {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address.FullAddress();
    }
    public void StandardDetails() {
        System.Console.WriteLine($"\tTitle: {this._title}");
        System.Console.WriteLine($"\tDescription: {this._desc}");
        System.Console.WriteLine($"\tDate: {this._date}");
        System.Console.WriteLine($"\tTime: {this._time}");
        System.Console.WriteLine($"\tAddress: {this._address}");
    }
    public abstract void FullDetails();
    public virtual void SetType() {
        _type = "standard";
    }
    public void ShortDescription() {
        System.Console.WriteLine($"\tType: {this._type}");
        System.Console.WriteLine($"\tTitle: {this._title}");
        System.Console.WriteLine($"\tDate: {this._date}");
    }
}