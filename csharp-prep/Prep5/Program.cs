using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        string name;
        Console.Write("What is your name? ");
        name = Console.ReadLine();
        return name;
    }
    static int PromptUsersNumber()
    {
        int number;
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        return number;
    }
    static int PromptUsersBirthYear()
    {
        int year;
        Console.Write("Enter your birth year: ");
        year = int.Parse(Console.ReadLine());
        return year;
    }

    static int SquareNumber(int number)
    {
        int square = number^2;
        return square;
    }
    static void DisplayResult(string name, int year, int sqaure)
    {
        int age;
        age = 2026 - year;
        Console.WriteLine($"{name}, your number squared is {sqaure}.");
        Console.WriteLine($"{name}, you will turn {age}");

    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUsersNumber();
        int year = PromptUsersBirthYear();
        int square = SquareNumber(number);
        DisplayResult(name, year, square);


    }
}