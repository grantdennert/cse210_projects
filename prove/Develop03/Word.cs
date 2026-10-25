public class Word
{
    private string _word;
    private bool _isHidden;
    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetWord()
    {
        if (_isHidden == true)
        {
            string hiddenWord = new string('_', _word.Length);
            return hiddenWord;
        }
        else
        {
            return _word;
        }
    }
}