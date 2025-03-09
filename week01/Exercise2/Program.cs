using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());
        if (marks >= 90)
        {
            Console.WriteLine("A");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("B");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("C");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
        if (marks >= 70)
        {
            Console.WriteLine("Passed congratulations.");
        }
        else
        {
            Console.WriteLine("Failed revise harder.");
        }
    }
}