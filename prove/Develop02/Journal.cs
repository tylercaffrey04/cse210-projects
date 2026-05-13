class Journal
{
    List<JournalEntry> _entries = new List<JournalEntry>();

    public void CreateEntries()
    {
        JournalEntry entry = new JournalEntry();
        entry.CreateJournalEntry();
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void WriteToFile()
    {
        foreach(JournalEntry entry in _entries)
        {
            string data = entry.CreateFileSystemString();
        }
    }
    public void ReadFromFile()
    {
        
    }
}