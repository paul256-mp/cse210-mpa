public class EternalQuest
    {
        private List<Goal> _goals = new List<Goal>();
        public IReadOnlyList<Goal> Goals => _goals.AsReadOnly();
        public int Score { get; private set; }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordEvent(int goalIndex)
        {
            if (goalIndex < 0 || goalIndex >= _goals.Count)
                throw new ArgumentOutOfRangeException(nameof(goalIndex));

            Goal goal = _goals[goalIndex];
            int pointsEarned = goal.RecordEvent();
            Score += pointsEarned;
        }

        public void DisplayGoals()
        {
            Console.WriteLine("Current Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"Score:{Score}");
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetSerializedString());
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string scoreLine = reader.ReadLine();
                if (scoreLine.StartsWith("Score:"))
                {
                    Score = int.Parse(scoreLine.Substring(6));
                }
                else
                {
                    throw new InvalidDataException("Score not found in file.");
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string type = parts[0];
                    string[] data = parts[1].Split(',');

                    switch (type)
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(
                                data[0],
                                data[1],
                                int.Parse(data[2]),
                                bool.Parse(data[3])));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(
                                data[0],
                                data[1],
                                int.Parse(data[2])));
                            break;
                        case "ChecklistGoal":
                            _goals.Add(new ChecklistGoal(
                                data[0],
                                data[1],
                                int.Parse(data[2]),
                                int.Parse(data[3]),
                                int.Parse(data[4]),
                                int.Parse(data[5])));
                            break;
                        default:
                            throw new InvalidDataException($"Unknown goal type: {type}");
                    }
                }
            }
        }
    }