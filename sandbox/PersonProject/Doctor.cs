namespace PersonProject;

internal class Doctor(string degree, string firstName, string lastName, int age, int weight)
    : Person(firstName, lastName, age, weight)
{
    public override string GetPersonInformation()
    {
        return $"Degree:{degree} {base.GetPersonInformation()}";

    }

    public override double GetSalary()
    {
        return 350000.00;
    }
}