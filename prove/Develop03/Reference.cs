using System;

class Reference
{
    private string BookName;
    private int Chapter;
    private int Verse;
    private int EndVerse; 


    public void SetReference(string bookName, int chapter, int verse)
    {
        BookName = bookName;
        Chapter = chapter;
        Verse = verse;
        EndVerse = 0;
    }

    public void SetRange(string bookName, int chapter, int verse, int endVerse)
    {
        BookName = bookName;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndVerse != 0)
            return BookName + " " + Chapter.ToString() + ":" + Verse.ToString() + "-" + EndVerse.ToString();
        else
            return BookName + " " + Chapter.ToString() + ":" + Verse.ToString();
    }
}
