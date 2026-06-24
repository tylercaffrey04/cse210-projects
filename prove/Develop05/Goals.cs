namespace Develop05;

public class Goals
{
    private List<Goal> _goals = new List<Goal>();

    public void CreateGoal(int goalType, string goalName, string description, int points)
    {
        
        if(goalType == 1)
        {
            
            var goal = new Goal(goalName, description, points);
            _goals.Add(goal);
        }
        else if (goalType == 2)
        {
            var goal = new EternalGoal(goalName, description, points);
            _goals.Add(goal);
        }
        else if (goalType == 3)
        {
            var goal = new CheckListGoal(goalName, description, points);
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid Goal");
        }
    }
    public void LoadGoals()
    {
        
    }

    public void SaveGoals()
    {
        
    }
    public float CalculatePoints()
    {
        if (_goals.Count == 0)
        {
            return 0f;
        }
        else
        {
            float totalScore = 0;
            foreach(var goal in _goals)
            {
                totalScore += goal.PointsFromGoal();
            }

            return totalScore;
        }

    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals");
        }
        else
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.DisplayGoal());
            }
        }

    }
}