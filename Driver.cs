using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    public class Driver
    {
        private Int32 number;
        private String name;
        private String vehicle;

        public Driver(Int32 number, String name, String vehicle)
        {
            this.number = number;
            this.name = name;
            this.vehicle = vehicle;
        }

        public Int32 Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public String NumberString
        {
            get { return this.number.ToString(); }
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public String Vehicle
        {
            get { return this.vehicle; }
            set { this.vehicle = value; }
        }
    }
}
