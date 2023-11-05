
using System;

class Reference
{
    public string BookName { get; private set; }
    public int Chapter { get; private set; }
    public int Verse { get; private set; }
    public int? EndVerse { get; private set; }

    // Constructor for a single verse
    public Reference(string bookName, int chapter, int verse)
    {
        BookName = bookName;
        Chapter = chapter;
        Verse = verse;
        EndVerse = null;
    }

    // Constructor for a verse range
    public Reference(string bookName, int chapter, int verse, int endVerse)
    {
        BookName = bookName;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndVerse.HasValue)
            return $"{BookName} {Chapter}:{Verse}-{EndVerse.Value}";
        else
            return $"{BookName} {Chapter}:{Verse}";
    }
}
