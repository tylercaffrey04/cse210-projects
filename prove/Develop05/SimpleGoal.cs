namespace Develop05;

public class SimpleGoal(string name, string description, int points, bool completed) : Goal(name, description, points, completed)
{
    public override string GetFileString()
    {
        return "1:"+base.GetFileString();
        
    }
}