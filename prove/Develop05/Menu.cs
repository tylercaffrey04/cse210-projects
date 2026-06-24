using System.Reflection.Metadata.Ecma335;

namespace Develop05;

public class Menu
{
    private Goals _myGoals = new Goals();
    public void Start()
    {
        while (true)
        {


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
            int ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
            {
                GoalCreationMenu();
            }
            else if (ans == 2)
            {
                _myGoals.DisplayGoals();
                Console.WriteLine("Press any key to Return to Main Menu...");
                Console.ReadLine();
            }
            else if (ans == 3)
            {
                _myGoals.SaveGoals();
            }
            else if (ans == 4)
            {
                _myGoals.LoadGoals();
            }
            else if (ans == 5)
            {

            }
            else if (ans == 6)
            {
                break;
            }
        }
    }

    public void GoalCreationMenu()
    {
        int goalType = 0;
        string goalName = "";
        string goalDescription = "";
        int points = 0;
        Console.Clear();
        Console.WriteLine("""
                          Goal Options:
                          1.) Simple Goal
                          2.) Eternal Goal
                          3.) Checklist Goal
                          """);
        goalType = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Name of Goal: ");
        goalName = Console.ReadLine();
        Console.WriteLine("Description of Goal: ");
        goalDescription = Console.ReadLine();
        Console.WriteLine("Point value of Goal: ");
        points = Convert.ToInt32(Console.ReadLine());
        _myGoals.CreateGoal(goalType, goalName, goalDescription, points);
    }
}