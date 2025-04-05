using System;
using System.Threading;

public class Activity
{
    // Fields
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Properties (optional, if needed)
    public int Duration => _duration;

    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        
        // Input validation
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            Console.Write("Enter the duration of the activity in seconds: ");
        }

        Console.WriteLine("\nPrepare to begin...");
        PauseWithAnimation(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("Loading");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        Console.Write("Starting in ");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    // Virtual method to be overridden by derived classes
    public virtual void Run()
    {
        DisplayStartingMessage();
        // Default behavior (can be overridden)
        DisplayEndingMessage();
    }
}
