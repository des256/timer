using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    public class Entry
    {
        private Evenement evenement;
        private Int32 stopwatch;
        private Int32 number;
        private Int64 msec;

        public Entry(Evenement evenement, Int32 stopwatch, Int32 number, Int64 msec)
        {
            this.evenement = evenement;
            this.stopwatch = stopwatch;
            this.number = number;
            this.msec = msec;
        }

        public String NumberString
        {
            get { return this.number.ToString("D"); }
            set { this.number = Int32.Parse(value); }
        }

        public String Msec
        {
            get
            {
                int fms = (int)(this.msec / 10);
                int hun = fms % 100;
                fms = (fms - hun) / 100;
                int sec = fms % 60;
                fms = (fms - sec) / 60;
                int min = fms;
                return min.ToString("D2") + ":" + sec.ToString("D2") + "." + hun.ToString("D2");
            }
        }

        public String Name
        {
            get { Driver p = evenement.FindDriver(this.number); if (p != null) return p.Name; else return null; }
        }

        public String Vehicle
        {
            get { Driver p = evenement.FindDriver(this.number); if(p != null) return p.Vehicle; else return null; }
        }

        public Int32 Stopwatch
        {
            get { return this.stopwatch; }
            set { this.stopwatch = value; }
        }

        public Int64 Value
        {
            get { return this.msec; }
            set { this.msec = value; }
        }

        public Int32 Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

    }
}
