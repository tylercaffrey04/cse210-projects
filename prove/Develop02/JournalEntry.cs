class JournalEntry
{
    string _date;
    string _prompt;
    string _response;

    string[] _prompts = {"How are you feeling today","Who did you talk to today?", "HOw have you seen God's hand in your life today?", "Best food from today?", "Whom wilt thou serve?" }; // expand prompt list

    public void CreateJournalEntry(string date = null, string prompt = null, string text = null)
    {

        // add randomization of prompts
        if(date != null && prompt != null && text != null)
        {
            _date = date;
            _prompt = prompt;
            _response = text;
        }
        else
        {
            Random rand = new Random();
            _date = DateTime.Now.ToShortDateString();
            _prompt = _prompts[rand.Next(5)];
            Console.WriteLine(_prompt);
            _response = Console.ReadLine();
        }

    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}, {_prompt} - {_response}");
    }
    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }

}

