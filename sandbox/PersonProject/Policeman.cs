namespace PersonProject;

internal class Policeman(string weapons, string firstName, string lastName, int age, int weight)
    : Person(firstName, lastName, age, weight)
{
    
    public override string GetPersonInformation()
    {
        return $"Weapons:{weapons} {base.GetPersonInformation()}";

    }

    public override double GetSalary()
    {
        return 100000.00;
    }
}