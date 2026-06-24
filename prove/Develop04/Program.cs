namespace Develop04;

internal static class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathe = new BreathingActivity("A breathing Activity to help you calm down.");
        
        breathe.Run();
    }
}