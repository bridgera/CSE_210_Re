
using System;

class Word
{
    public string Content { get; private set; }
    public bool IsHidden { get; set; }

    public Word(string content)
    {
        Content = content;
        IsHidden = false;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : Content;
    }
}
