
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int usernumber = 0;
        while (usernumber != -1)
        {
            Console.Write("Enter a number (-1 to quit): ");
            usernumber = int.Parse(Console.ReadLine());
            if (usernumber != -1)
            {
                numbers.Add(usernumber);
            }
        }

        //computing for the sum of the numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is {sum}");

        //computing for the average of the numbers
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is {average}");

        //computing for the maximum number
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is {max}");
        }
    }

