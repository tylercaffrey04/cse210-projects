using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNum = int.Parse(Console.ReadLine());

        int response = 0;

        do
        {
            Console.Write("What is your guess? ");
            response = int.Parse(Console.ReadLine());
            if(response > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if(response < magicNum)
            {
                Console.WriteLine("Higher");
            }
        } while(response != magicNum);

        Console.WriteLine("You did it!");
    }
}