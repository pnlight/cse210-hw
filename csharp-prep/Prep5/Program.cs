using System;

class Program
{
    static void Main(string[] args)
    {
        NR_DisplayWelcome();
        string name = NR_PromptUserName();
        int num = NR_PromptNumber();
        int square = NR_Sqr(num);
        
        DisplayResult(name, square);
    }

    static void NR_DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string NR_PromptUserName()
    {
        Console.Write("Please enter your name:");
        string username = Console.ReadLine();
        return username; 
    }

    static int NR_PromptNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int NR_Sqr(int num)
    {
        int squared = num * num;
        return squared;
    }

    static void DisplayResult(string name, int square)
    {
        Console.Write($"{name}, the square of your number is {square}");
    }
}