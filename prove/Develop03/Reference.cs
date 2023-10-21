using System.Linq.Expressions;

class Reference
{
    private string _book;
    private string _chapter;
    private string _first;
    private string _last;
    private string _reference;

    public Reference(string book, string chapter, string first, string last){
        this._book = book;
        this._chapter = chapter;
        this._first = first;
        this._last = last;
        this._reference = book + " " + chapter + ":" + first + "-" + last;
    }
    public Reference(string book, string chapter, string first){
        this._book = book;
        this._chapter = chapter;
        this._first = first;
        this._last = "";
        this._reference = book + " " + chapter + ":" + first ;
    }
    public string SetReference(string reference){
        this._reference = reference;

        string stringReference = this._reference;
        return stringReference;
    }
    public string GetReference(){
        return this._reference;
    }
}