  class Program
    {
        static void Main(string[] args)
        {
            EternalQuest quest = new EternalQuest();

            while (true)
            {
                Console.WriteLine("Eternal Quest - Main Menu");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateGoal(quest);
                        break;
                    case "2":
                        quest.DisplayGoals();
                        break;
                    case "3":
                        RecordEvent(quest);
                        break;
                    case "4":
                        SaveGoals(quest);
                        break;
                    case "5":
                        LoadGoals(quest);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.WriteLine($"Current Score: {quest.Score}\n");
            }
        }

        static void CreateGoal(EternalQuest quest)
        {
            Console.WriteLine("Select goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string typeInput = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string desc = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            switch (typeInput)
            {
                case "1":
                    quest.AddGoal(new SimpleGoal(name, desc, points));
                    break;
                case "2":
                    quest.AddGoal(new EternalGoal(name, desc, points));
                    break;
                case "3":
                    Console.Write("Enter target times: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    quest.AddGoal(new ChecklistGoal(name, desc, points, bonus, target));
                    break;
                default:
                    Console.WriteLine("Invalid type.");
                    break;
            }
        }

        static void RecordEvent(EternalQuest quest)
        {
            var goals = quest.Goals;
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals to record.");
                return;
            }
            Console.WriteLine("Select a goal to record:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
            }
            Console.Write("Enter goal number: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= goals.Count)
            {
                quest.RecordEvent(index - 1);
                Console.WriteLine("Event recorded!");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        static void SaveGoals(EternalQuest quest)
        {
            Console.Write("Enter filename to save: ");
            string filename = Console.ReadLine();
            quest.SaveToFile(filename);
            Console.WriteLine("Goals saved.");
        }

        static void LoadGoals(EternalQuest quest)
        {
            Console.Write("Enter filename to load: ");
            string filename = Console.ReadLine();
            quest.LoadFromFile(filename);
            Console.WriteLine("Goals loaded.");
        }
    }
}