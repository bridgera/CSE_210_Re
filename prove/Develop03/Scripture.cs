using System;
using System.Collections.Generic;

class Scripture
{
    public Reference ScriptureReference;
    public List<string> Words;
    public List<bool> WordsHidden;


    public void SetScripture(Reference scriptureReference, string text)
    {
        ScriptureReference = scriptureReference;
        Words = new List<string>(text.Split(' '));
        WordsHidden = new List<bool>();

        for (int i = 0; i < Words.Count; i++)
        {
            WordsHidden.Add(false);
        }
    }

    public void Display()
    {
        Console.WriteLine(ScriptureReference.ToString());
        for (int i = 0; i < Words.Count; i++)
        {
            if (WordsHidden[i])
            {
                Console.Write("___ "); 
            }
            else
            {
                Console.Write(Words[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count = 1)
    {
        Random rng = new Random();


        int hideableWordsCount = 0;
        for (int i = 0; i < WordsHidden.Count; i++)
        {
            if (!WordsHidden[i])
            {
                hideableWordsCount++;
            }
        }

        while (count > 0 && hideableWordsCount > 0)
        {
            int index = rng.Next(Words.Count);
            if (!WordsHidden[index])
            {
                WordsHidden[index] = true;
                count--;
                hideableWordsCount--;
            }
        }
    }

    public bool AreAllWordsHidden()
    {
        for (int i = 0; i < WordsHidden.Count; i++)
        {
            if (!WordsHidden[i])
            {
                return false;
            }
        }
        return true;
    }
}
