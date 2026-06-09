namespace Spinner;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.CursorVisible = false;
        string animationString = "\\|/|";
        for (int i = 0; i < 20; i++)
        {
            Console.Write(animationString[i % animationString.Length]);
            Thread.Sleep(250);
            Console.Write("\b");

        }
        Console.CursorVisible = true;
    }
}