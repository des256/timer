using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    public class Standings
    {
        // set of entrysets

        private Evenement evenement;
        private SortedSet<EntrySet> entries = new SortedSet<EntrySet>(new EntrySetComparer());

        public Standings(Evenement evenement)
        {
            this.evenement = evenement;
            List<EntrySet> entrylist = new List<EntrySet>();

            // build entry sets
            foreach (Entry entry in this.evenement.Entries)
                if ((entry.Number > -1) && (entry.Value > 10000))
                {
                    // find driver in list
                    Driver driver = this.evenement.FindDriver(entry.Number);
                    if (driver != null)
                    {
                        // find already existing entryset for this driver
                        EntrySet found = null;
                        foreach (EntrySet entryset in entrylist)
                            if (entryset.Driver.Number == entry.Number)
                            {
                                found = entryset;
                                break;
                            }
                        if (found == null)
                        {
                            // not found, so add new entryset
                            found = new EntrySet(0,driver);
                            found.Add(entry);
                            entrylist.Add(found);
                        }
                        else
                            found.Add(entry);
                    }
                }

            // sort
            foreach (EntrySet entryset in entrylist)
                entries.Add(entryset);

            // assign the ranks
            int rank = 1;
            foreach(EntrySet entryset in this.entries)
            {
                entryset.Rank = rank;
                rank++;
            }
        }

        public SortedSet<EntrySet> Entries
        {
            get { return entries; }
        }

        public List<String> List
        {
            get
            {
                List<String> list = new List<String>();
                foreach(EntrySet set in this.entries)
                    list.Add(set.FormattedLine);
                return list;
            }
        }
    }
}
