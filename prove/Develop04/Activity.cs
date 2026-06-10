namespace Develop04;

public class Activity(string name, string description)
{

    private int _duration;

    private DateTime _endtime;

    public void StartActivity(string message)
    {
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine(description);
        Console.Write("How long do you wish to do the activity for? ");
        _duration = int.Parse(Console.ReadLine());
        Countdown(message, _duration);
    }

    public void Countdown(string message, int duration)
    {
        Console.CursorVisible = false;
        Console.Write($"{message}: ");
        while(duration > 0)
        {
            Console.Write($"{duration--,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");

        }
        Console.WriteLine("");
        Console.CursorVisible = true;
    }
}