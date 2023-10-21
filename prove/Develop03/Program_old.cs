// using System;
// using System.Collections.Concurrent;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Scripture scripture1 = new Scripture();
        
//         scripture1.AddReference("Luke 8:38-39");
//         scripture1.AddVerse("Now the man out of whom the devils were departed besought him that he might be with him: but Jesus sent him away, saying,");
//         scripture1.AddVerse("Return to thine own house, and shew how great things God hath done unto thee. And he went his way, and published throughout the whole city how great things Jesus had done unto him.");
        
//         string verse = scripture1.GetVerse(0);

//         string modifiedScripture = scripture1.AlterVerse(verse);

//         System.Console.WriteLine(modifiedScripture);
//     }   
// }