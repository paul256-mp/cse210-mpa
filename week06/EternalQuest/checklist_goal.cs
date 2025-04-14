 public class ChecklistGoal : Goal
    {
        private int _bonus;
        private int _target;
        private int _timesCompleted;

        public ChecklistGoal(string name, string description, int points, int bonus, int target, int timesCompleted = 0)
            : base(name, description, points)
        {
            _bonus = bonus;
            _target = target;
            _timesCompleted = timesCompleted;
        }

        public override int RecordEvent()
        {
            _timesCompleted++;
            int total = _points;
            if (_timesCompleted == _target)
            {
                total += _bonus;
            }
            return total;
        }

        public override bool IsComplete()
        {
            return _timesCompleted >= _target;
        }

        public override string GetStatus()
        {
            return $"[{(_timesCompleted >= _target ? "X" : " ")}] {_name} ({_description}) -- Completed {_timesCompleted}/{_target} times";
        }

        public override string GetSerializedString()
        {
            return $"{base.GetSerializedString()},{_bonus},{_target},{_timesCompleted}";
        }
    }
