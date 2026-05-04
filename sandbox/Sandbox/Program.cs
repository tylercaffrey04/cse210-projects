using System;
using System.Security.Cryptography;

class Program
{
    static void DisplayGreeting()
    {
        Console.WriteLine("Why hello there traveler.");
    }
    static int AddNumber(int n1, int n2, int n3)
    {
        int total = n1 + n2 + n3;
        return total;
    }

    static void Main(string[] args)
    {
        DisplayGreeting();
        int total = AddNumber(10,15,45);
        Console.WriteLine(total);
        // Super coooool program we got running here dont you worry
        // Console.WriteLine("Hello Sandbox World!");
    
        // int x = 10;



        // for (int i=0; i<10; i++)
        // {
        //     Console.WriteLine(i);
        // }
        // while (x<32)
        // {
        //     Console.WriteLine(x);
        //     if (x == 11) Console.WriteLine("Hey Jude");
        //     if (x == 12) Console.WriteLine("Hey There Delilah");
        //     x++;
        // }
        // int age;
        // do
        // {
        //     Console.Write("Enter you age: ");
        //     age = int.Parse(Console.ReadLine());
        // } while(age<0 || age>125 );

        // for (int i =0; i <= 32; i++)
        // {
        //     uint powerNumber = (uint)Math.Pow(2,i);
        //         Console.Write($"2 to the power of {i} is {powerNumber}");
        //         Console.WriteLine($", 0x{powerNumber.ToString("X")}");
        // }

        // List<int> myData = new List<int>();

        // myData.Add(1);
        // myData.Add(2);
        // myData.Add(3);
        // myData.Add(4);
        // myData.Add(5);
        // myData.Add(6);
        // myData.Add(7);
        // myData.Add(8);
        // myData.Add(9);

        // foreach (int i in myData)
        // {
        //     Console.WriteLine(i);
        // }
    }
}