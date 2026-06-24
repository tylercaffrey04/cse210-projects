namespace Develop05;

public class EternalGoal(string name, string description, int points) : Goal(name, description, points)
{
    private int _timesCompleted = 0;
    private bool _completed = false;

    public override void RecordEvent()
    {
        base.RecordEvent();
    }
}