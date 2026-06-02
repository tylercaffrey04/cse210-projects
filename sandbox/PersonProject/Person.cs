using System.Security.Cryptography;

class Person
{
    string _firstName;
    string _lastName;
    int _age;
    int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }
    public string GetPersonInformation()
    {
        return $"Name:{_firstName} {_lastName}, Age:{_age}, Weight: {_weight}";
    }
}