using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private readonly Random _random = new Random();

    public ReflectingActivity() 
        : base("Reflection Activity", "This activity will help you reflect on meaningful experiences in your life.")
    {
    }

    public override void Run()
    {
        base.DisplayStartingMessage();
        
        Console.WriteLine("\nConsider the following prompt:\n");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---\n");
        
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("Starting in... ");
        ShowCountDown(3);

        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"\n> {question} ");
            ShowSpinner(5); // Pause for reflection
        }

        base.DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }
}