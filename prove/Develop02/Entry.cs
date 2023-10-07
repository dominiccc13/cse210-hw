using System.ComponentModel.Design;

public class Entry 
{
    public string _entry;
    public string _date;
    public string _prompt;
    public Journal journal;
    public void NewEntry(){
            int selection = 0;
            while(selection == 0){
                Entry entry = new Entry();
                entry._prompt = entry.GeneratePrompt();
                entry._entry = Console.ReadLine();
                entry._date = entry.GetDate();
                journal._journalEntries.Add(entry);

                System.Console.WriteLine("Would you like to make another entry? 0 for yes, 1 for no.");
                selection = int.Parse(Console.ReadLine());
            }
    }
    public string GeneratePrompt(){
        List<string> promptsList = new List<string>();
        promptsList.Add("Who was the most interesting person I interacted with today?");
        promptsList.Add("What was the best part of my day?");
        promptsList.Add("How did I see the hand of the Lord in my life today?");
        promptsList.Add("What was the strongest emotion I felt today?");
        promptsList.Add("If I had one thing I could do over today, what would it be?");
        Random randomNumber = new Random();
        int randomPromptIndex = randomNumber.Next(0,5);
        System.Console.WriteLine(promptsList[randomPromptIndex]);
        return promptsList[randomPromptIndex];
    }
    public string GetDate(){
        DateTime currentDate = DateTime.Now;
        string year = currentDate.Year.ToString();
        string month = currentDate.Month.ToString();
        string day = currentDate.Day.ToString();
        string date = $"{month}/{day}/{year}";
        return date;   
    }
    public void IterateEntries(List<Entry> entries){
        foreach (Entry entry in entries){
            System.Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}\nEntry: {entry._entry}");
        }
    }
}