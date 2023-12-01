class Video 
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentsList;

    public Video(string title, string author, int length, List<Comment> commentsList) {
        this._title = title;
        this._author = author;
        this._length = length;
        this._commentsList = commentsList;
    }

    public int ReturnComments() {
        return this._commentsList.Count();
    }

    public string GetTitle() {
        return this._title;
    }
    
    public string GetAuthor() {
        return this._author;
    }
    
    public int GetLength() {
        return this._length;
    }
    
    public List<Comment> GetComments() {
        return this._commentsList;
    }
}