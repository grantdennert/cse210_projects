public class Scripture
{
    private List<Word> _scripture;
    private Reference _reference;

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;
        _scripture = new List<Word>();
        string[] words = scripture.Split(' ');
        foreach (string text in words)
        {
            Word word = new Word(text);
            _scripture.Add(word);
        }
    }
    public void HideWords(int amountToHide)
    {
        List<Word> shownWords = new List<Word>();
        foreach (Word word in _scripture)
        {
            if (word.IsHidden() == false)
            {
                shownWords.Add(word);
            }
        }
        
        Random random = new Random();
        for (int i = 0; i < amountToHide && shownWords.Count > 0; i++)
        {
            int wordToHide = random.Next(shownWords.Count);
            shownWords[wordToHide].Hide();
            shownWords.RemoveAt(wordToHide);
        }
    }
    public bool IsCompletelyHidden()
    {
        bool hidden = true;
        foreach (Word word in _scripture)
        {
            if (word.IsHidden() == false)
            {
                hidden = false;
            }
        }
        return hidden;
    }
    public string GetScripture()
    {
        string allText = _reference.GetReference();
        foreach (Word word in _scripture)
        {
            allText = allText + ' ' + word.GetWord();
        }
        return allText;
    }
}