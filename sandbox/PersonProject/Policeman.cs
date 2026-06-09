namespace PersonProject;

internal class Policeman(string weapons, string firstName, string lastName, int age, int weight)
    : Person(firstName, lastName, age, weight)
{
    private string _weapons = weapons;
}