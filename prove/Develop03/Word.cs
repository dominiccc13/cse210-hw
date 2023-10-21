class Word 
{ 
    private string _word;
    public string SetWord(string word){
        this._word = word;

        string stringWord = this._word;
        return stringWord;
    }
    public string AlterWord(){
        string[] wordArray = this._word.Split(" ");
        string newWord = "";

        Random rnd = new Random();

        List<int> indexes = new List<int>();
        indexes.Add(-1);

        for (int i = 0; i<3; i++){
            int index = rnd.Next(0, wordArray.Length);
            foreach (int value in indexes){
                while (index == value){
                    index = rnd.Next(0, wordArray.Length);
                }
            }
            indexes.Add(index);

            wordArray[index] = "____";
        }

        foreach (string word in wordArray){
            newWord += word + " ";
        }

        this._word = newWord;
        return this._word;
    }
    
}