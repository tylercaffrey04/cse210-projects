using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture sr = new Scripture("John", "3", "16", "For God so loved the world that he gave his one and only Son,\n that whoever believes in him shall not perish but have eternal life.");
        bool again = true;
        do
        {
            
            Console.Clear();
            sr.Display();
            Console.Write("Press enter to hide words or 'q' to quit: ");
            string ans = Console.ReadLine();
            if (ans == "q")
            {
                again = false;
            }
            else
            {
                sr.HideWord();
                again = true;
            }

        }while(again);
    }
}