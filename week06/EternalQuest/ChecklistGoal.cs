namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _bonus;
        private int _target;
        private int _amountCompleted;

        public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted = 0) 
            : base(name, description, points)
        {
            _bonus = bonus;
            _target = target;
            _amountCompleted = amountCompleted;
        }

        public override int RecordEvent()
        {
            if (_amountCompleted < _target)
            {
                _amountCompleted++;
                return _amountCompleted == _target ? Points + _bonus : Points;
            }
            return 0;
        }

        public override bool IsComplete() => _amountCompleted >= _target;

        public override string GetDetailsString()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {base.GetDetailsString()} -- Completed {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{Name},{Description},{Points},{_bonus},{_target},{_amountCompleted}";
        }
    }
}