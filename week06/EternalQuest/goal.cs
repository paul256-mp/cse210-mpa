 using System.IO;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public abstract int RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetStatus();
        public virtual string GetSerializedString()
        {
            return $"{GetType().Name}:{_name},{_description},{_points}";
        }
    }
}
