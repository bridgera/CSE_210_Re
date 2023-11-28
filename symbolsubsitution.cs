// SymbolSubstitution.cs
using System;
using System.Collections.Generic;


    public class SymbolSubstitution
    {
        private Dictionary<char, char> symbolMap;

        public SymbolSubstitution(Dictionary<char, char> symbolMap)
        {
            this.symbolMap = symbolMap;
        }

        public char Substitute(char ch)
        {
            return symbolMap.ContainsKey(ch) ? symbolMap[ch] : ch;
        }
    }

