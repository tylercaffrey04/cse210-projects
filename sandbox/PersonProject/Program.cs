namespace PersonProject;
 
internal static class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
 
    }
    public static void Main(string[] args)
    {
        var police = new Policeman("Taser", "Robert", "Smith", 31, 210);
        var doctor = new Doctor("Neurology", "Jane", "Smith", 31, 210);

        Console.WriteLine(doctor.GetPersonInformation());
        Console.WriteLine(police.GetPersonInformation());

        List<Person> myPeople = new List<Person>();
        myPeople.Add(police);
        myPeople.Add(doctor);

        foreach (var person in myPeople)
        {
            DisplayPersonInformation(person);
            Console.WriteLine(person.GetSalary());
        }
    }

}