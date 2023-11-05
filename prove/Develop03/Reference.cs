using System;

class Reference
{
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _endVerse; 


    public void SetReference(string bookName, int chapter, int verse, int endVerse = 0)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_endVerse != 0)
            return _bookName + " " + _chapter.ToString() + ":" + _verse.ToString() + "-" + _endVerse.ToString();
        else
            return _bookName + " " + _chapter.ToString() + ":" + _verse.ToString();
    }
}
