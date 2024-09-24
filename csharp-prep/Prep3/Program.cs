using System;
using System.Formats.Asn1;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        string continuePlaying = "yes";
        int response;
        int guessed = 0;

        Console.WriteLine("Welcome to Guess Magic Number game");
        Console.WriteLine("You will have to guess the magic number");
        Console.WriteLine("");

        do
        {
            Console.Write("What is your guess? ");
            response = int.Parse(Console.ReadLine());
            guessed++;

            if (response == magicNumber)
            {
                Console.WriteLine("");
                Console.WriteLine($"Congratulations, you got that right in {guessed} attempts.");
                Console.Write("Do you wish to play again? (yes / no) ");
                continuePlaying = Console.ReadLine();
                magicNumber = randomGenerator.Next(1, 100);
                Console.WriteLine("");
            }
            else if (response < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

        } while (continuePlaying == "yes");

        Console.WriteLine("Hope you enjoyed our game. See you next time.");

    }
}