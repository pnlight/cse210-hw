using System;

class Program
{
    static void Main(string[] args)
    {
    string input = "yes";    
    while (input == "yes")
    {

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 11);

        int guess = -1;

        int tries = 1;

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magic)
            {
                Console.WriteLine("Higher");
                tries++;
            }
            else if (guess > magic)
            {
                Console.WriteLine("Lower");
                tries++;
            }
            else
            {
                Console.WriteLine($"You got it in {tries} tries!");
            }
        }
    Console.Write("Do you want to continue? ");
    input = Console.ReadLine();
    }
}
}