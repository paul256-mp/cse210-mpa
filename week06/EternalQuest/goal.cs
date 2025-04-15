namespace EternalQuest
{
    public abstract class Goal
    {
        private string _name;
        private string _description;
        private int _points;

        protected Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public abstract int RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetStringRepresentation();

        public virtual string GetDetailsString()
        {
            return $"{_name} ({_description})";
        }

        protected string Name => _name;
        protected string Description => _description;
        protected int Points => _points;
    }
}