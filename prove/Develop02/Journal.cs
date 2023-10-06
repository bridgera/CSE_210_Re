using System.Collections.Generic;

namespace Develop02
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();
        public string _journalName;

        public void AddEntry(Entry entry)
        {
    
            _entries.Add(entry);
        
        }

        
    }
}
