class Address 
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country) {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUSA() {
        bool inUSA = this._country.ToLower() == "usa" ? true : false;
        return inUSA;
    }

    public string FullAddress() {
        return $"{this._streetAddress}\n\t{this._city}, {this._state}, {this._country}";
    }
}