using System.Data;
using System.Security.Cryptography;
namespace PersonProject;

internal class Person(string firstName, string lastName, int age, int weight)
{
    private int _weight = weight;
    private int _age = age;
    public string GetPersonInformation()
    {
        return $"Name:{firstName} {lastName}, Age:{_age}, Weight: {_weight}";
    }

    public void ChangeWeight(int update)
    {
        _weight += update;
    }

    public void SetAge(int newAge)
    {
        _age = newAge;
        if (newAge < 0 || newAge > 115)
        {
            _age = 0;
            Console.WriteLine("Age must be between 0 and 115");
        }
    }
    
}