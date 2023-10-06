using System.Collections.Generic;

namespace Develop02
{
    public class Journal
    {
        public List<Entry> Entries = new List<Entry>();
        public string JournalName;

        public void AddEntry(Entry entry)
        {
    
            Entries.Add(entry);
        
        }

        
    }
}
