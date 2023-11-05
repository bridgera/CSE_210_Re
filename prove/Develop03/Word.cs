using System;

class Word
{
    private string Content;
    private bool IsHidden;

    public void SetContent(string content)
    {
        Content = content;
        IsHidden = false; 
    }

    public override string ToString()
    {
        if (IsHidden)
        {
            return "_____";
        }
        else
        {
            return Content;
        }
    }
}
