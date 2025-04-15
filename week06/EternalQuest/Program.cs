using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
   class Program
   {
      static List<Goal> goals = new List<Goal>();
      static int totalPoints = 0;

      static void Main(string[] args)
      {
         Console.WriteLine("Welcome to the Eternal Quest Program!");
         LoadGoals();

         while (true)
         {
            DisplayMenu();
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
               case "1": CreateNewGoal(); break;
               case "2": ListGoals(); break;
               case "3": SaveGoals(); break;
               case "4": LoadGoals(); break;
               case "5": RecordEvent(); break;
               case "6":
                  Console.WriteLine("Goodbye!");
                  return;
               default:
                  Console.WriteLine("Invalid choice. Please try again.");
                  break;
            }
         }
      }

      static void DisplayMenu()
      {
         Console.WriteLine("\n===== Eternal Quest Menu =====");
         Console.WriteLine($"Current Score: {totalPoints} points");
         Console.WriteLine("1. Create New Goal");
         Console.WriteLine("2. List Goals");
         Console.WriteLine("3. Save Goals");
         Console.WriteLine("4. Load Goals");
         Console.WriteLine("5. Record Event");
         Console.WriteLine("6. Quit");
         Console.Write("Select an option: ");
      }

      static void CreateNewGoal()
      {
         Console.WriteLine("\n===== Create New Goal =====");
         Console.WriteLine("Select Goal Type:");
         Console.WriteLine("1. Simple Goal (one-time)");
         Console.WriteLine("2. Eternal Goal (repeating)");
         Console.WriteLine("3. Checklist Goal (requires multiple completions)");
         Console.Write("Enter choice: ");

         string typeChoice = Console.ReadLine() ?? "0";
         string type = "";

         switch (typeChoice)
         {
            case "1": type = "Simple"; break;
            case "2": type = "Eternal"; break;
            case "3": type = "Checklist"; break;
            default:
               Console.WriteLine("Invalid choice. Goal creation cancelled.");
               return;
         }

         Console.Write("Enter goal name: ");
         string name = Console.ReadLine() ?? "Unnamed Goal";

         Console.Write("Enter goal description: ");
         string description = Console.ReadLine() ?? "No description";

         Console.Write("Enter point value: ");
         if (!int.TryParse(Console.ReadLine(), out int points))
         {
            Console.WriteLine("Invalid points. Defaulting to 0.");
            points = 0;
         }

         int target = 0;
         int bonus = 0;

         if (type == "Checklist")
         {
            Console.Write("How many times to complete for bonus? ");
            if (!int.TryParse(Console.ReadLine(), out target))
            {
               Console.WriteLine("Invalid number. Defaulting to 1.");
               target = 1;
            }

            Console.Write("Enter bonus points: ");
            if (!int.TryParse(Console.ReadLine(), out bonus))
            {
               Console.WriteLine("Invalid number. Defaulting to 0.");
               bonus = 0;
            }
         }

         Goal newGoal = GoalFactory.CreateGoal(type, name, description, points, target, bonus);
         goals.Add(newGoal);

         Console.WriteLine("Goal created successfully!");
      }

      static void ListGoals()
      {
         Console.WriteLine("\n===== Your Goals =====");

         if (goals.Count == 0)
         {
            Console.WriteLine("No goals created yet.");
            return;
         }

         for (int i = 0; i < goals.Count; i++)
         {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
         }
      }

      static void RecordEvent()
      {
         if (goals.Count == 0)
         {
            Console.WriteLine("No goals available to record.");
            return;
         }

         ListGoals();
         Console.Write("Enter the number of the goal you completed: ");

         if (int.TryParse(Console.ReadLine(), out int goalNumber) && 
         goalNumber > 0 && goalNumber <= goals.Count)
         {
            Goal selectedGoal = goals[goalNumber - 1];
            int pointsEarned = selectedGoal.RecordEvent();
            totalPoints += pointsEarned;

            Console.WriteLine($"\nCongratulations! You earned {pointsEarned} points!");

            if (selectedGoal is ChecklistGoal checklist && checklist.IsComplete())
            {
               Console.WriteLine("You completed the checklist and earned a bonus!");
            }
         }
         else
         {
            Console.WriteLine("Invalid goal selection.");
         }
      }

      static void SaveGoals()
      {
         string filename = "goals.txt";

         try
         {
            using (StreamWriter writer = new StreamWriter(filename))
            {
               writer.WriteLine(totalPoints);

               foreach (Goal goal in goals)
               {
                  writer.WriteLine(goal.GetStringRepresentation());
               }
            }

            Console.WriteLine("Goals saved successfully!");
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error saving goals: {ex.Message}");
         }
      }

      static void LoadGoals()
      {
         string filename = "goals.txt";

         if (!File.Exists(filename))
         {
            Console.WriteLine("No saved goals found.");
            return;
         }

         try
         {
            string[] lines = File.ReadAllLines(filename);

            if (lines.Length > 0 && int.TryParse(lines[0], out int savedPoints))
            {
               totalPoints = savedPoints;
            }

            goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
               Goal loadedGoal = GoalFactory.CreateFromString(lines[i]);
               goals.Add(loadedGoal);
            }

            Console.WriteLine("Goals loaded successfully!");
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error loading goals: {ex.Message}");
         }
      }
   }
}