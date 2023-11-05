using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _scriptureReference;
    private List<string> _words;
    private List<bool> _wordsHidden;

    public void SetScripture(Reference scriptureReference, string text)
    {
        _scriptureReference = scriptureReference;
        _words = new List<string>(text.Split(' '));
        _wordsHidden = new List<bool>();

        for (int i = 0; i < _words.Count; i++)
        {
            _wordsHidden.Add(false);
        }
    }

    public void Display()
    {
        Console.WriteLine(_scriptureReference.ToString());
        for (int i = 0; i < _words.Count; i++)
        {
            if (_wordsHidden[i])
            {
                Console.Write("___ "); 
            }
            else
            {
                Console.Write(_words[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count = 1)
    {
        Random rng = new Random();

        int hideableWordsCount = 0;
        for (int i = 0; i < _wordsHidden.Count; i++)
        {
            if (!_wordsHidden[i])
            {
                hideableWordsCount++;
            }
        }

        while (count > 0 && hideableWordsCount > 0)
        {
            int index = rng.Next(_words.Count);
            if (!_wordsHidden[index])
            {
                _wordsHidden[index] = true;
                count--;
                hideableWordsCount--;
            }
        }
    }

    public bool AreAllWordsHidden()
    {
        for (int i = 0; i < _wordsHidden.Count; i++)
        {
            if (!_wordsHidden[i])
            {
                return false;
            }
        }
        return true;
    }
}
