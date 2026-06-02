class Program
{
    public static void Main(string[] args)
    {
        Policeman police = new Policeman("Taser", "Robert", "Smith", 31, 210);

        Console.WriteLine(police.GetPersonInformation());
    }


}