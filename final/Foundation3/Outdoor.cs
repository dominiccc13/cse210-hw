class Outdoor : Event
{
    private string _weather;

    public Outdoor(string weather, string title, string desc, string date, string time, Address address) : 
    base(title, desc, date, time, address) {
        _weather = weather;
    }
    public override void FullDetails() {
        System.Console.WriteLine($"\tTitle: {this._title}");
        System.Console.WriteLine($"\tDescription: {this._desc}");
        System.Console.WriteLine($"\tDate: {this._date}");
        System.Console.WriteLine($"\tTime: {this._time}");
        System.Console.WriteLine($"\tAddress: {this._address}");
        System.Console.WriteLine($"\tType: {this._type}");

        System.Console.WriteLine($"\tWeather Forecast: {this._weather}");
    }
    public override void SetType() {
        _type = "Outdoor";
    }
}