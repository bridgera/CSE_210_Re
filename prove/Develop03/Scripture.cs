
using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public Reference ScriptureReference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference scriptureReference, string text)
    {
        ScriptureReference = scriptureReference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(ScriptureReference.ToString());
        Console.WriteLine(string.Join(" ", Words));
    }

    public void HideRandomWords(int count = 1)
    {
        Random rng = new Random();

        // Select words that are not hidden yet
        var wordsToHide = Words.Where(word => !word.IsHidden).ToList();

        // Randomly hide words
        for (int i = 0; i < count && wordsToHide.Count > 0; i++)
        {
            int index = rng.Next(wordsToHide.Count);
            wordsToHide[index].IsHidden = true;
            wordsToHide.RemoveAt(index);
        }
    }

    public bool AreAllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }
}
