class Reception : Event 
{
    private string _email;

    public Reception(string email, string title, string desc, string date, string time, string address) : 
    base(title, desc, date, time, address) {
        _email = email;
    }
    public override void FullDetails() {
        System.Console.WriteLine($"Title: {this._title}");
        System.Console.WriteLine($"Description: {this._desc}");
        System.Console.WriteLine($"Date: {this._date}");
        System.Console.WriteLine($"Time: {this._time}");
        System.Console.WriteLine($"Address: {this._address}");
        System.Console.WriteLine($"RSVP Here: {this._email}");
    }
}