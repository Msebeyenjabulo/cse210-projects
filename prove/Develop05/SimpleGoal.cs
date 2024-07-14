namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public bool IsComplete
        {
            get => _isComplete;
            set => _isComplete = value;
        }

        public SimpleGoal(string name, string description, int points) 
            : base(name, description, points)
        {
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            return $"SimpleGoal: {_shortName} - {_description} [{(_isComplete ? "X" : " ")}]";
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
        }
    }
}
