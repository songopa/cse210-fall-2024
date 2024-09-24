using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string rawScore;
        string letter;
        string pass;
        string sign;

        Console.Write("What is your score? ");
        rawScore = Console.ReadLine();
        int score = int.Parse(rawScore);

        // determing the grade
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";       
        }
        else if (score >= 70)
        {
            letter = "C";
            
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // determing if passed or not
        if (score >= 70) 
        {
            pass = "Congratulations, you have passed!";
        }
        else
        {
            pass = "You did not pass, more effort required next time.";
        }

        // assigning a positive or negative to the grade
        int lastDigit = score % 10;
        if (lastDigit >= 7) 
        {
            if (score > 93 || score < 60)
            {
                sign = "";
            }
            else
            {
                sign = "+";
            }
        }
        else if (lastDigit < 3)
        {
            if (score < 60)
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"\nYour grade is {letter}{sign}, {pass}");
        Console.WriteLine("");

    }
}