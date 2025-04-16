public class NegativeGoal : Goal
{
    private bool _isComplete;

    public NegativeGoal(string name, string description, int points)
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

    public override int GetPoints()
    {
        return _points * -1;
    }
    public override string GetStringRepresentation()
    {
        return $"Negative Goal:{_shortName},{_description},{_points * -1},{_isComplete}";
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] - {base.GetDetailsString()}";
    }
}