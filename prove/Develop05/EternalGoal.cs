namespace Develop05;

public class EternalGoal(string name, string description, int points, bool completed, int timesCompleted) : Goal(name, description, points, completed)
{
    private int _timesCompleted = timesCompleted;

    public override void RecordEvent()
    {
        _timesCompleted++;
        Completed = true;
    }

    public override string DisplayGoal()
    {
        return base.DisplayGoal();
    }

    public override string GetFileString()
    {
        return "2:"+base.GetFileString() +$".{_timesCompleted}";
    }

    public override int PointsFromGoal()
    {
        return base.PointsFromGoal() *  _timesCompleted;
    }
}