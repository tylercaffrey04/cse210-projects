namespace Develop04;

public class Activity(string name, string description)
{
    
    private int _duration;

    private DateTime _endtime;

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine(description);
        Console.Write("How long do you wish to do the activity for? ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void Countdown(string[] message, int messageDuration)
    {
        Console.CursorVisible = false;
        while (_duration > 0)
        {
            int x = 0;
            int measure = messageDuration;
            for(int i = 0; i < measure; i++)
            {
                Console.Write($"{message[x]}");
                while (messageDuration > 0)
                {
                    Console.Write($"{messageDuration--,2}");
                    Thread.Sleep(1000);
                    Console.Write("\b\b");
                    _duration--;
                }

                Console.Write(string.Concat(Enumerable.Repeat("\b", message[x].Length)));
                x = i % message.Length;
                    
                messageDuration = measure;
            }
            
        }
        Console.WriteLine("");
        Console.CursorVisible = true;
    }
}