using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letter; 
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";

        }
        else
        {
            letter = "F";
        }
        if(grade >= 70)
        {
            Console.WriteLine($"Grade:{letter}");
            Console.WriteLine("You have passed the course!");

        }
        else
        {
            Console.WriteLine($"Grade:{letter}");
            Console.WriteLine("You did not pass.");
        }
    }
}