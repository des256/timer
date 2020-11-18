using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    public class EntrySetComparer : Comparer<EntrySet>
    {
        public override int Compare(EntrySet a, EntrySet b)
        {
            if (a.Fastest.Value < b.Fastest.Value)
                return -1;
            else if (a.Fastest.Value == b.Fastest.Value)
                return 0;
            else
                return 1;
        }
    }
}
