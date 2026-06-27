using System.Reflection.Metadata.Ecma335;

namespace Develop05;

public class Menu
{
    private Goals _myGoals = new Goals();
    public void Start()
    {
        while (true)
        {

            Console.Clear();
            Console.WriteLine($"Number of points: {_myGoals.CalculatePoints()}");
            Console.WriteLine("""
                              Menu Options:
                              1.) Create New Goal
                              2.) List Goals
                              3.) Save Goals
                              4.) Load Goals
                              5.) Record Event
                              6.) Quit
                              """);
            string ans = Console.ReadLine();
            if (ans == "1")
            {
                GoalCreationMenu();
            }
            else if (ans == "2")
            {
                _myGoals.DisplayGoals();
                Console.WriteLine("Press any key to Return to Main Menu...");
                Console.ReadLine();
            }
            else if (ans == "3")
            {
                _myGoals.SaveGoals();
            }
            else if (ans == "4")
            {
                _myGoals.LoadGoals();
            }
            else if (ans == "5")
            {
                CompleteGoalMenu();
            }
            else if (ans == "6")
            {
                break;
            }
            else
                return;
        }
    }

    public void GoalCreationMenu()
    {
        while (true)
        {

            Console.Clear();
            Console.WriteLine("""
                              Goal Options:
                              1.) Simple Goal
                              2.) Eternal Goal
                              3.) Checklist Goal
                              """);
            string ans = Console.ReadLine();
            if (ans.Contains("1") || ans.Contains("2") || ans.Contains("3"))
            {
                var goalType = Convert.ToInt32(ans);
                Console.Clear();
                Console.WriteLine("Name of Goal: ");
                var goalName = Console.ReadLine();
                Console.WriteLine("Description of Goal: ");
                var goalDescription = Console.ReadLine();
                Console.WriteLine("Point value of Goal: ");
                var points = Convert.ToInt32(Console.ReadLine());
                if (goalType == 3)
                {
                    Console.WriteLine("times to be Completed:");
                    int timesToComplete = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bonus Points for Completion: ");
                    int bonusPoints = Convert.ToInt32(Console.ReadLine());
                    _myGoals.CreateGoal(goalType, goalName, goalDescription, points, false ,0,timesToComplete, bonusPoints);
                    
                }
                else
                    _myGoals.CreateGoal(goalType, goalName, goalDescription, points);
                break;
            }
            else
            {
                return;
            }
        }
        
    }

    private void CompleteGoalMenu()
    {
        Console.Clear();
        float oldPoints = _myGoals.CalculatePoints();
        Console.WriteLine("Goal to Record: ");
        _myGoals.DisplayGoals();
        int ans = Convert.ToInt32(Console.ReadLine());
        _myGoals.CompleteGoal(ans-1);
        float newPoints = _myGoals.CalculatePoints();
        Console.WriteLine($"Points recieved: {newPoints - oldPoints}");
        Console.WriteLine("Press any key to Return to Main Menu...");
        Console.ReadLine();
    }
}