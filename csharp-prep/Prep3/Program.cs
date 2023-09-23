using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);
        System.Console.WriteLine($"{magicNumber}");

        System.Console.Write("Guess a number: ");
        int guessNumber = int.Parse(Console.ReadLine());

        while (guessNumber != magicNumber)
        {
            if (guessNumber > magicNumber)
                {
                    Console.Write("You've guessed too high. Guess again: ");
                    guessNumber = int.Parse(Console.ReadLine());
                }
            else
            {
                Console.Write("You've guessed too low. Guess again: ");
                    guessNumber = int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("You guessed correctly.");
    }
}