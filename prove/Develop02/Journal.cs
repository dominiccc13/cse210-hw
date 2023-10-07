using System.Runtime.Intrinsics.Arm;

public class Journal{
    public List<Entry> _journalEntries = new List<Entry>();
    public Entry entry;

    public void WriteToFile(){
        System.Console.WriteLine("Provide the filename at which you will store your entries:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename)){
            foreach(Entry entry in _journalEntries){
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._entry}");
            }
        }
    }
    public void LoadFile(Journal journalName){
        System.Console.WriteLine("Provide the filename from which you will load your entries:");
        string filename = Console.ReadLine();

        Entry entry2 = new Entry();
        journalName._journalEntries.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach(string line in lines){
            string[] parts = line.Split(",");
            entry2._date = parts[0];
            entry2._prompt = parts[1];
            entry2._entry = parts[2]; 
            journalName._journalEntries.Add(entry2);
        }
    }
}