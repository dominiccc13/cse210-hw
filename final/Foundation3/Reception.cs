class Reception : Event 
{
    private string _email;

    public Reception(string email, string title, string desc, string date, string time, Address address) : 
    base(title, desc, date, time, address) {
        _email = email;
    }
    public override void FullDetails() {
        System.Console.WriteLine($"\tTitle: {this._title}");
        System.Console.WriteLine($"\tDescription: {this._desc}");
        System.Console.WriteLine($"\tDate: {this._date}");
        System.Console.WriteLine($"\tTime: {this._time}");
        System.Console.WriteLine($"\tAddress: {this._address}");
        System.Console.WriteLine($"\tType: {this._type}");

        System.Console.WriteLine($"\tRSVP Here: {this._email}");
    }
    public override void SetType() {
        _type = "Reception";
    }
}