using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Journal journal = new Journal();
        do
        {
            int response = menu.ProcessMenu();
            if(response == 5)
            {
                break;
            }
            menu.DetermineAction(response, journal);
            
        }while(true);



    }
}