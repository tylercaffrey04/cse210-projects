using System.Security.Cryptography;
namespace PersonProject;

internal class Person(string firstName, string lastName, int age, int weight)
{
    public string GetPersonInformation()
    {
        return $"Name:{firstName} {lastName}, Age:{age}, Weight: {weight}";
    }
}