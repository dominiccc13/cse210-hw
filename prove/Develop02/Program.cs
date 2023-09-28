using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        var entry1 = new Entry();
        entry1._entry = "This is an entry.";
        string prompt = entry1.PromptGenerator();
        System.Console.WriteLine(prompt); 
    }
}

public class Entry 
{
    public string _entry;

    public string PromptGenerator()
    {
        List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
        return prompts[0];
    }

    public void GetDate() 
    {

    }

    
    
}