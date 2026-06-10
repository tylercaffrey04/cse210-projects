using System;
using Develop04;

internal static class Program
{
    static void Main(string[] args)
    {
        Activity myActivity = new Activity("Breathing Activity", "A super cool breathing activity");
        myActivity.StartActivity("Breath In: ");
    
    }
}



