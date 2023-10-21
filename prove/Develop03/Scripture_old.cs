// using System.Numerics;

// class Scripture 
// {
//     private List<string> _references = new List<string>();
//     private List<string> _verse = new List<string>();
//     private List<int> _removedWords = new List<int>();
//     public void AddReference(string reference){
//        _references.Add(reference);
//     }
//     public void AddVerse(string verse){
//        _verse.Add(verse);
//     }
//     public string GetVerse(int index){
//         return _verse[index];
//     }
//     public string AlterVerse(string verse){
//         string scriptureModified = "";
//         string[] textArray = verse.Split(" ");
        
//         Random rnd = new Random();
        
//         int previousRandomIndex = -1;
//         for(int i=0; i<3; i++){
//             int randomIndex = rnd.Next(0,textArray.Length);
            
//                 if(previousRandomIndex == randomIndex){
//                     while(previousRandomIndex == randomIndex){
//                         randomIndex = rnd.Next(0,textArray.Length+1);
//                     }
//                 }

//             _removedWords.Add(randomIndex);
//             previousRandomIndex = randomIndex;
//         }

//         foreach(int integer in _removedWords){
//             textArray[integer] = "_____";
//         }
        
//         foreach(string word in textArray){
//             scriptureModified += $"{word} ";
//         } 
        
//         return scriptureModified;
//     }
// }