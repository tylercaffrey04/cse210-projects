namespace Develop05;

public class Goal(string name, string description, int points)
{
    private bool _completed = false;
    public virtual void RecordEvent()
    {
        _completed = true;
    }

    public virtual int PointsFromGoal()
    {
        if(_completed)
            return points;
        else
            return 0;
        
    }

    public virtual string GetFileString()
    {
        return $"{name}.{description}.{points},";
    }

    public virtual string DisplayGoal()
    {
        return $"Goal name: {name}:\nDescription: {description}\nPoints:{PointsFromGoal()}\n";
    }
    public bool IsCompleted()
    {
        return _completed;
    }
}