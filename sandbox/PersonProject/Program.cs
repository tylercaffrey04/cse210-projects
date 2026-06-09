namespace PersonProject;

internal static class Program
{
    public static void Main(string[] args)
    {
        var police = new Policeman("Taser", "Robert", "Smith", 31, 210);
        var doctor = new Doctor("Neurology", "Jane", "Smith", 31, 210);

        Console.WriteLine(doctor.GetDoctorInformation());
        Console.WriteLine(police.GetPersonInformation());

    }
}