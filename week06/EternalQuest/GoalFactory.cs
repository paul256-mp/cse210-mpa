namespace EternalQuest
{
    public static class GoalFactory
    {
        public static Goal CreateGoal(string type, string name, string description, int points, int target = 0, int bonus = 0)
        {
            return type switch
            {
                "Simple" => new SimpleGoal(name, description, points),
                "Eternal" => new EternalGoal(name, description, points),
                "Checklist" => new ChecklistGoal(name, description, points, bonus, target),
                _ => throw new ArgumentException("Invalid goal type")
            };
        }

        public static Goal CreateFromString(string data)
        {
            string[] parts = data.Split(':');
            string type = parts[0];
            string[] details = parts[1].Split(',');

            return type switch
            {
                "SimpleGoal" => new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3])),
                "EternalGoal" => new EternalGoal(details[0], details[1], int.Parse(details[2])),
                "ChecklistGoal" => new ChecklistGoal(
                    details[0], 
                    details[1], 
                    int.Parse(details[2]), 
                    int.Parse(details[3]), 
                    int.Parse(details[4]), 
                    int.Parse(details[5])),
                _ => throw new ArgumentException("Unknown goal type")
            };
        }
    }
}