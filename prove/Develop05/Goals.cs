namespace Develop05;
using System.Runtime.InteropServices;
using System.IO;
public class Goals
{
    private List<Goal> _goals = new List<Goal>();

    public void CreateGoal(int goalType, string goalName, string description, int points, [Optional] bool completed, [Optional] int timesCompleted, [Optional] int timesToComplete, [Optional] int bonusPoints)
    {
        
        if(goalType == 1)
        {
            var goal = new SimpleGoal(goalName, description, points, completed);
            _goals.Add(goal);
        }
        else if (goalType == 2)
        {
            var goal = new EternalGoal(goalName, description, points,completed,timesCompleted);
            _goals.Add(goal);
        }
        else if (goalType == 3)
        {
            var goal = new CheckListGoal(goalName, description, points,completed,timesCompleted, timesToComplete, bonusPoints);
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid Goal");
        }
    }
    public void LoadGoals()
    {
        Console.Clear();
        Console.WriteLine("Name of file (Don't include file types): ");
        var filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"C:\\Users\\Muske\\Desktop\\cse210-projects\\prove\\Develop05\\{filename}.csv");
        foreach (var line in lines)
        {
            string[] parts = line.Split(':');
            Console.WriteLine(parts[0]);
            string[] details = parts[1].Split(".");
            if (parts[0] == "1")
            {
                CreateGoal(int.Parse(parts[0]), details[0], details[1], int.Parse(details[2]), bool.Parse(details[3]));
            }
            else if (parts[0] == "2")
            {
                CreateGoal(int.Parse(parts[0]), details[0], details[1], int.Parse(details[2]),bool.Parse(details[3]), int.Parse(details[4]));
                
            }
            else if (parts[0] == "3")
            {
                CreateGoal(int.Parse(parts[0]), details[0], details[1], int.Parse(details[2]),bool.Parse(details[3]), int.Parse(details[4]),int.Parse(details[5]),int.Parse(details[6]));
                
            }
        }
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.WriteLine("Name of file (Don't include file types): ");
        var filename = Console.ReadLine();
        using var outputFile = new StreamWriter($"C:\\Users\\Muske\\Desktop\\cse210-projects\\prove\\Develop05\\{filename}.csv");
        foreach (var goal in _goals)
        {
            outputFile.WriteLine(goal.GetFileString());
        }
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

    public void CompleteGoal(int adjustedIndex)
    {
        _goals[adjustedIndex].RecordEvent();
    }
    public void DisplayGoals()
    {
        Console.Clear();
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_goals[i].DisplayGoal()}");
            }
        }

    }
}