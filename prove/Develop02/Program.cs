using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.CreateEntries();
        journal.CreateEntries();
        journal.DisplayEntries();

    }
}