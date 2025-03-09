using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string username = promptUsername();
        int usernumber = promptUserNumber();

        int squarednumber = SquaredNumber(usernumber);

        DisplayResult(username, squarednumber);
        static int SquaredNumber(int number)
        {
            return number * number;
        }
    
        static string promptUsername()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;

        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        static int promptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }
}