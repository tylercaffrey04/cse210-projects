using System.Data;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verseEnd;
    private string _verseStart;
    private string _text;

    public Scripture(string book, string chapter, string verse, string text)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _text = text;
        InitializeList();
        InitializeReference();
    }
    public Scripture(string book, string chapter, string verseStart, string verseEnd, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;


        _text = text;
        InitializeList();
        InitializeReference();
    }
    private void InitializeList()
    {
        string[] wordList = _text.Split(" ");
        for (int i = 0; i < wordList.Length; i++)
        {
            Word word = new Word(wordList[i]);
            _words.Add(word);
        }
    }
    private void InitializeReference()
    {
        if(_verse != null)
            _reference = new Reference(_book, _chapter, _verse);
        else
            _reference = new Reference(_book, _chapter, _verseStart, _verseEnd);
    }
    public void HideWord()
    {
        for(int i = 0; i<3; i++)
        {
            Random rand = new Random();
            int index = rand.Next(_words.Count);
            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
            }
            else
            {
                i--;
            }
            
        }
    }
    public void Display()
    {
        _reference.Display();
        for(int i=0; i<_words.Count; i++)
        {
            _words[i].Display();
        }
    }

}