using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Since NegativeGoal affects the score negatively, deduct points
        GoalManager.Instance.DeductPoints(_points);
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"[ ] {_name} - {_description} (-{_points} points)";

    public override string GetStringRepresentation() => $"NegativeGoal:{_name},{_description},{_points}";
}
