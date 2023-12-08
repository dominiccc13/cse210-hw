class Address 
{
    private string _streetAddress;
    private string _city;
    private string _state;

    public Address(string streetAddress, string city, string state) {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
    }

    public string FullAddress() {
        return $"{this._streetAddress}\n\t{this._city}, {this._state}";
    }
}