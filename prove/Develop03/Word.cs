using System;

class Word
{
    public string Content;
    public bool IsHidden;

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
