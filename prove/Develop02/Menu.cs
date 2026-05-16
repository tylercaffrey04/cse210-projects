using System.Formats.Tar;
using System.Linq.Expressions;

class Menu
{
    public int ProcessMenu()
    {
        int userInput = -1;
        bool again;
        do
        {
            again = false;
            Console.WriteLine("Welcome To the Journal");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Entries to File");
            Console.WriteLine("4. Read Entries from File");
            Console.WriteLine("5. Quit");
            Console.Write("Action Number: ");
            try
            {
                userInput = int.Parse(Console.ReadLine());
                
            }
            catch(Exception)
            {
                Console.WriteLine("Please only enter a number 1-5!");
                again = true;
            }
            if (userInput > 5 || userInput<0)
            {
                Console.WriteLine("Please only enter a number 1-5!");
                again = true;
            }
        }while(again);
        return userInput;

    }
    public void DetermineAction(int response, Journal journal)
    {

        if(response == 1)
        {
            journal.CreateEntries();
        }
        else if(response == 2)
        {
            journal.DisplayEntries();
        }
        else if(response == 3)
        {
            Console.Write("Name of File: ");
            string filename = Console.ReadLine();
            journal.WriteToFile(filename);
        }
        else if(response == 4)
        {
            Console.Write("Name of File: ");
            string filename = Console.ReadLine();
            journal.ReadFromFile(filename);
        }
    }
}