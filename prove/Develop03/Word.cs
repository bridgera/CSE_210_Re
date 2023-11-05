class Word
{
    private string _content;
    private bool _isHidden;

    public void SetContent(string content)
    {
        _content = content;
        _isHidden = false; 
    }

    public override string ToString()
    {
        if (_isHidden)
        {
            return "_____";
        }
        else
        {
            return _content;
        }
    }
}
