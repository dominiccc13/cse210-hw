class Comment
{
    private string _name;
    private string _commentText;
    
    public Comment(string name, string commentText) {
        this._name = name;
        this._commentText = commentText;
    }

    public string GetText() {
        return _commentText;
    }
}