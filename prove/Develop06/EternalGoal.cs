using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never complete, so just record the points
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => $"[ ] {_name} - {_description}";

    public override string GetStringRepresentation() => $"EternalGoal:{_name},{_description},{_points}";
}
