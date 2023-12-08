using System;

class Program
{

    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        System.Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        System.Console.Write("Enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static double SquareNumber(double number)
    {
        double squareNumber = Math.Pow(number, 2);
        return squareNumber;
    }

    static void DisplayResult(string name, int number)
    {
        double squareNumber = SquareNumber(number);
        System.Console.WriteLine($"{name}, your number squared is {squareNumber}.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), PromptUserNumber());
    }
}