namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) 
            : base(name, description, points) { }

        public override int RecordEvent() => Points;

        public override bool IsComplete() => false;

        public override string GetDetailsString()
        {
            return $"[ ] {base.GetDetailsString()}";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{Name},{Description},{Points}";
        }
    }
}