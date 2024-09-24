using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int square = SquareNumber(PromptUserNumber());
        DisplayResults(userName, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName () 
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber ()
    {
        Console.Write("Please enter you favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber (int number)
    {
        return number*number;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}