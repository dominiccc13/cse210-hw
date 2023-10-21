using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Luke", "8", "38", "39");
        Word word1 = new Word();
        Scripture scripture1 = new Scripture();

        string referenceText = reference1.GetReference();
        string wordText = word1.SetWord("Now the man out of whom the devils were departed besought him that he might be with him: but Jesus sent him away, saying, Return to thine own house, and shew how great things God hath done unto thee. And he went his way, and published throughout the whole city how great things Jesus had done unto him.");
        string scriptureText = scripture1.MakeScripture(referenceText, wordText);

        string run = "run";
        do
        {
            Console.Clear();
            
            System.Console.WriteLine(scriptureText);

            wordText = word1.AlterWord();
            scriptureText = scripture1.MakeScripture(referenceText, wordText);
                
            Console.Write("Type quit to exit. Press any key to run again: ");
            run = Console.ReadLine();
        } while (run != "quit");

    }   
}