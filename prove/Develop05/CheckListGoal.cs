namespace Develop05;

public class CheckListGoal(string name, string description, int points, bool completed,int timesCompleted,int timesToComplete, int bonusPoints) : Goal(name, description, points, completed)
{
    private int _timesCompleted = timesCompleted;
    

    public override void RecordEvent()
    {
        _timesCompleted++;
        Completed = true;

    }
    public override int PointsFromGoal()
    {
        if(_timesCompleted >= timesToComplete)
            return base.PointsFromGoal() * _timesCompleted + bonusPoints;
        else
        {
            return base.PointsFromGoal() * _timesCompleted;
        }
    }

    public override string GetFileString()
    {
        return "3:"+base.GetFileString() + $".{_timesCompleted}.{timesToComplete}.{bonusPoints}";
    }

    public override string DisplayGoal()
    {
        return base.DisplayGoal() + $"| Completed {_timesCompleted} /{timesToComplete} times";
    }
}