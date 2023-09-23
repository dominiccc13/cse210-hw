using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
            // User creates list of numbers.
        List<int> numbers = new List<int>();
        int entry = 1;
        do 
        {
            Console.Write("Create a list of numbers. Include 2 negative numbers. Enter 0 when complete: ");
            int number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                entry = 0;
            }
        }
        while (entry != 0);

            // Total and average of user-created list is calculated. 
            // Max and min values from list are identified. 
        int total = 0;
        int max = 0;
        int min = 999999999;
        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];
            if (numbers[i] >= max)
            {
                max = numbers[i];
            }
            if (numbers[i] <= min && numbers[i] > 0)
            {
                min = numbers[i];
            }
        }
        float average = total/numbers.Count;

            // Prints total, average, max, and min. 
        System.Console.WriteLine($"Total: {total}");
        System.Console.WriteLine($"Average: {average}");
        System.Console.WriteLine($"Max value: {max}");
        System.Console.WriteLine($"Min value (not including negatives): {min}");
    }
}