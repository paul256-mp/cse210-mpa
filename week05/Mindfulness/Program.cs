using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App! 🌿");
        Console.WriteLine("This program helps you practice mindfulness through guided activities.");

        while (true)
        {
            Console.WriteLine("\n=== Main Menu ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity (1-4): ");

            string choice = Console.ReadLine()?.Trim();

            // Validate input
            if (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("⛔ Invalid input. Please try again.");
                continue;
            }

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    Console.WriteLine("\nThank you for using the Mindfulness App. Goodbye! 🌟");
                    return;
                default:
                    Console.WriteLine("⛔ Invalid choice. Please select 1-4.");
                    break;
            }
        }
    }
}

