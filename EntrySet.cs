using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    // driver and all corresponding entries

    public class EntrySet
    {
        private int rank;
        private Driver driver;
        private List<Entry> entries = new List<Entry>();

        public EntrySet(int rank,Driver driver)
        {
            this.rank = rank;
            this.driver = driver;
        }

        public Entry Fastest
        {
            // get fastest entry for this driver
            get
            {
                if (entries.Count() < 1)
                    return null;
                Entry fastest = entries[0];
                for (int i = 0; i < entries.Count(); i++)
                    if (entries[i].Value < fastest.Value)
                        fastest = entries[i];
                return fastest;
            }
        }

        public List<Entry> Entries
        {
            get { return entries; }
        }

        public Driver Driver
        {
            // get driver
            get
            {
                return driver;
            }
        }

        public int Rank
        {
            get
            {
                return rank;
            }

            set
            {
                rank = value;
            }
        }

        public String FormattedLine
        {
            // get formatted output for standings box
            get
            {
                return rank + ". " + Fastest.Msec + ": " + driver.Number + ". " + driver.Name;
            }
        }

        public int Count()
        {
            // return number of entries
            return entries.Count();
        }

        public void Add(Entry entry)
        {
            entries.Add(entry);
        }
    }
}
