class Outdoor : Event
{
    private string _weather;
    public Outdoor(string weather, string title, string desc, string date, string time, string address) : 
    base(title, desc, date, time, address) {
        _weather = weather;
    }
    public override void FullDetails() {
        System.Console.WriteLine($"Title: {this._title}");
        System.Console.WriteLine($"Description: {this._desc}");
        System.Console.WriteLine($"Date: {this._date}");
        System.Console.WriteLine($"Time: {this._time}");
        System.Console.WriteLine($"Address: {this._address}");
        System.Console.WriteLine($"Weather Forecast: {this._weather}");
    }
}