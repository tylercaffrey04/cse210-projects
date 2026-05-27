using System.Security.Cryptography;

class Reference
{
    private string _reference = "";

    public Reference(string book, string chapter, string verse)
    {
        string reference = string.Concat(book, " ", chapter, ": ", verse);
        _reference = reference;
    }
    public Reference(string book, string chapter, string verseStart, string verseEnd)
    {
        string reference = string.Concat(book, " ", chapter, ": ", verseStart, "-", verseEnd);
        _reference = reference;
    }

    public void Display()
    {
        Console.WriteLine(_reference + ": ");
    }
}