using System.Collections.Generic;

namespace Develop02
{
    public class Journal
    {
        public List<Entry> Entries { get; set; } = new List<Entry>();
        public string JournalName { get; set; }

        public void AddEntry(Entry entry)
        {
            if (!Entries.Contains(entry))
            {
                Entries.Add(entry);
            }
        }
    }
}
