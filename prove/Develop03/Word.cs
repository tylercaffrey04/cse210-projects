class Word
{
    private bool _hidden = false;
    private string _text;

    public Word(string text)
    {
        _text = text;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public void Hide()
    {
        int digits = _text.Length;
        string newText = "";
        for(int i = 0; i < digits; i++)
        {
            newText = string.Concat(newText, "_");

        }
        _text = newText;
        _hidden = true;
    }
    public void Display()
    {
        Console.Write(_text + " ");
    }
}