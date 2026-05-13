class JournalEntry
{
    string _date;
    string _prompt;
    string _response;

    string[] _prompts = {"How are you feeling today","Who did you talk to today?" }; // expand prompt list

    public void CreateJournalEntry()
    {

        // add randomization of prompts
        _date = DateTime.Now.ToShortDateString();
        _prompt = _prompts[0];
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
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

