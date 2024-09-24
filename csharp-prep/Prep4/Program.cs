using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = 0;

        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        } while (newNumber != 0);

        int sum = numbers.Sum();
        float average = (float)numbers.Average();
        
        int largest = 0;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        int minPositive = 1000000000;
        foreach (int number in numbers)
        {
            if (number >=0 && number < minPositive)
            {
                minPositive = number;
            }
        }


        Console.WriteLine($"\nThe sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine($"The smallest positive number is {minPositive}");

        Console.WriteLine($"\nBelow is the sorted list:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}