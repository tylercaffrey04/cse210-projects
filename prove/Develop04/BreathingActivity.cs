namespace Develop04;

public class BreathingActivity(string description) : Activity ("Breathing Activity", description)
{
    private string[] _message = ["Breath in:", "Breath Out:"];
    private int _messageDuration = 4;

    public void Run()
    {
        StartActivity();
        Countdown(_message,  _messageDuration);
        
    }
}