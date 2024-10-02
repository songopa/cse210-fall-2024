public class Word
{
    private string _text;
    private bool _hidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public string GetDisplayText()
    {
        if (IsHidden())
        {
            return "____";
        } else
        {
            return _text;
        }
    }
}