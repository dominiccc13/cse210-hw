using System;
using System.ComponentModel.Design;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int runMenu = 1;

        while(runMenu!=5){
            System.Console.WriteLine("1. Create an entry\n2. Display your entries");
            System.Console.WriteLine("3. Write to a file\n4. Load a file\n5. Quit");
            int selection = int.Parse(Console.ReadLine());

            if(selection==1){
                // while(selection == 1){
                    Entry entry = new Entry();
                    entry._prompt = entry.GeneratePrompt();
                    entry._entry = Console.ReadLine();
                    entry._date = entry.GetDate();
                    journal._journalEntries.Add(entry);

                //     System.Console.WriteLine("Would you like to make another entry? 1 for yes, 0 for no.");
                //     selection = int.Parse(Console.ReadLine());
                // }
            }
            else if(selection==2){
                Console.Clear();
                Entry entryRun = new Entry();

                entryRun.IterateEntries(journal._journalEntries);
            }
            else if(selection==3){
                journal.WriteToFile();
            }
            else if(selection==4){
                journal.LoadFile(journal);
            }
            else{
                runMenu = 5;
            }
            System.Console.WriteLine("");
        }
    }
}