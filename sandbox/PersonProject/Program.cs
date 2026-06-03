class Program
{
    public static void Main(string[] args)
    {
        Policeman police = new Policeman("Taser", "Robert", "Smith", 31, 210);
        Doctor doctor = new Doctor("Neurology", "Jane", "Smith", 31, 210);

        Console.WriteLine(doctor.GetDoctorInformation());
        Console.WriteLine(police.GetPersonInformation());

    }
}