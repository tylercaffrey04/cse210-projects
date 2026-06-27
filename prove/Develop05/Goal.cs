namespace Develop05;

public class Goal(string name, string description, int points, bool completed)
{
    protected bool Completed = completed;

    public virtual void RecordEvent()
    {
        Completed = true;
    }

    public virtual int PointsFromGoal()
    {
        if(Completed)
            return points;
        else
            return 0;
        
    }

    public virtual string GetFileString()
    {
        return $"{name}.{description}.{points}.{Completed}";
    }

    public virtual void ReadFileString()
    {
        
    }
    public virtual string DisplayGoal()
    {
        if(Completed)
            return $"[x] Goal name: {name}| Description: {description}| Points:{points}\n";
        else
            return $"[ ] Goal name: {name}| Description: {description}| Points:{points}\n";
            
    }
    public bool IsCompleted()
    {
        return Completed;
    }
}