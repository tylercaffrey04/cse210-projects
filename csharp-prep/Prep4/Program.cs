using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        double response;
        List<double> myList = new List<double>();
        do
        {
            Console.Write("Enter a value");
            response = double.Parse(Console.ReadLine());

            myList.Add(response);

        }while(response != 0);

        double sum = 0;
        double highest = 0;
        foreach (int i in myList)
        {
            if(myList[i] > highest) highest = myList[i];

            sum += myList[i];

        }
        double avg = sum/myList.Count;


        Console.WriteLine(sum);
        Console.WriteLine(avg);
        Console.WriteLine(highest);
        
    }    
}