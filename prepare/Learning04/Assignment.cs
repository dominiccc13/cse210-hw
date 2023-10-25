class Assignment 
{
    protected string _name;
    protected string _topic;
    
    public Assignment(string name, string topic) {
        _name = name;
        _topic = topic;
    }
    public string GetSummary() {
        string name = this._name;
        string topic = this._topic;
        string nameAndTopic = name + " - " + topic;
        return nameAndTopic;
    }
}