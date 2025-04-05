using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private readonly List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int _itemCount;

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many items as you can in a certain area.")
    {
    }

    public override void Run()
    {
        base.DisplayStartingMessage();
        
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        
        Console.Write("Get ready... ");
        ShowSpinner(3);
        Console.WriteLine("\nStart listing now!\n");

        List<string> items = GetListFromUser();
        _itemCount = items.Count;

        Console.WriteLine($"\nYou listed {_itemCount} items! 🎉");
        base.DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        Console.WriteLine("(Keep entering items until the time runs out.)");
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine()?.Trim();
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
            else
            {
                Console.WriteLine("(Empty entries won't be counted.)");
            }
        }

        return items;
    }
}