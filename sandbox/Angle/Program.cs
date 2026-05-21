class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Beans");
        Angle angle = new Angle();
        angle.SetRadians(10);
        Console.WriteLine(angle.GetRadians());
    }
}