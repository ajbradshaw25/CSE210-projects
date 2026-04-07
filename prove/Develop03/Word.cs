public class Word
{
    public string _text;
    public bool IsHidden;

    public Word(string text)
    {
        _text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Show()
    {
        IsHidden = false;
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', _text.Length) : _text;
    }
}