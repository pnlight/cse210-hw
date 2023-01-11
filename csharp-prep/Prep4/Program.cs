using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -99999999;
        while (number != 0)
        {
            Console.Write("Enter a number: ");

            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }

        Console.WriteLine($"The sum is {sum}.");

        float avg = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is {avg}.");
        
        numbers.Sort();

        int maxval = numbers.Last();

        //#https://stackoverflow.com/questions/29028452/how-to-find-positive-minimum-number-in-array-c-sharp
        int minval = numbers.Where(i => i >= 0).Min();

        Console.WriteLine($"The largest number is {maxval}.");
        Console.WriteLine($"The smallest number is {minval}.");

        Console.WriteLine("The sorted list is: ");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

    }
}