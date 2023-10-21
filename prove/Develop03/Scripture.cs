class Scripture
{
    private string _scripture;
    public string MakeScripture(string reference, string word){
        this._scripture = reference + " " + word;
        
        string scriptureString = this._scripture.ToString();
        return scriptureString;
    }

}