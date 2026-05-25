class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(w => new Word(w))
                     .ToList();
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        int index = rand.Next(_words.Count);
        _words[index].Hide();
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + "\n" + text;
    }

    public bool AllHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}