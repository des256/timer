using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    class Stopwatch
    {
        System.Windows.Forms.Label label;
        private Int64 start_msec;
        private Int64 msec;
        private bool running;

        public Stopwatch(System.Windows.Forms.Label label)
        {
            this.label = label;
            StopReset();
        }

        public bool IsRunning()
        {
            return running;
        }

        public void StopReset()
        {
            Stop();
            this.msec = 0;
            label.Text = "00:00.00";
        }

        public void Stop()
        {
            this.running = false;
        }

        public void Start()
        {
            this.start_msec = System.DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            this.running = true;
        }

        public int GetTime()
        {
            return (int)this.msec;
        }

        public void Step()
        {
            if(this.running)
            {
                this.msec = System.DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond - this.start_msec;
                int fms = (int)(this.msec / 10);
                int hun = fms % 100;
                fms = (fms - hun) / 100;
                int sec = fms % 60;
                fms = (fms - sec) / 60;
                int min = fms;
                label.Text = min.ToString("D2") + ":" + sec.ToString("D2") + "." + hun.ToString("D2");
            }
        }
    }
}
