namespace PersonProject;

internal class Doctor(string degree, string firstName, string lastName, int age, int weight)
    : Person(firstName, lastName, age, weight)
{
    public string GetDoctorInformation()
    {
        return $"Degree:{degree} {GetPersonInformation()}";

    }
}