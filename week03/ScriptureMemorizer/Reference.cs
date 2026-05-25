class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse.ToString();
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = $"{startVerse}-{endVerse}";
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}