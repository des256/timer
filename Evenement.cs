using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.ComponentModel;


namespace Timer
{
    public class Evenement
    {
        public enum Type
        {
            SLALOM = 0,
            SPRINT = 1
        };

        private String filename;
        private DateTime date;
        private String name;
        private Type type;
        private BindingList<Driver> drivers;
        private BindingList<Entry> entries;
        private int last;

        public Evenement(String filename)
        {
            int highest_number = 0;
            this.filename = filename;
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreComments = true;
                settings.IgnoreProcessingInstructions = true;
                settings.IgnoreWhitespace = true;
                using (XmlReader reader = XmlReader.Create(filename, settings))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            if (reader.Name == "evenement")
                            {
                                this.name = reader.GetAttribute("naam");
                                if (this.name != null)
                                {
                                    String datumstring = reader.GetAttribute("datum");
                                    if (datumstring != null)
                                    {
                                        this.date = DateTime.Parse(datumstring);
                                        String typestring = reader.GetAttribute("type");
                                        if (typestring == "sprint")
                                            this.type = Evenement.Type.SPRINT;
                                        else
                                            this.type = Evenement.Type.SLALOM;
                                        this.drivers = new BindingList<Driver>();
                                        this.entries = new BindingList<Entry>();
                                    }
                                }
                            }

                            if (reader.Name == "deelnemer")
                            {
                                Int32 number = Int32.Parse(reader.GetAttribute("nummer"));
                                String name = reader.GetAttribute("naam");
                                String vehicle = reader.GetAttribute("voertuig");
                                drivers.Add(new Driver(number, name, vehicle));
                                if (number > highest_number)
                                    highest_number = number;
                            }

                            if (reader.Name == "tijd")
                            {
                                Int32 stopwatch = Int32.Parse(reader.GetAttribute("stopwatch"));
                                Int32 number = Int32.Parse(reader.GetAttribute("nummer"));
                                Int64 msec = Int64.Parse(reader.GetAttribute("msec"));
                                entries.Add(new Entry(this, stopwatch, number, msec));
                            }
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
            }

            for (int i = highest_number + 1; i <= 500; i++)
                drivers.Add(new Driver(i, "(naam onbekend)", "(voertuig onbekend)"));

            last = entries.Count();
            for (int i = last + 1; i <= 500; i++)
                entries.Add(new Entry(this, 0, -1, 0));
        }

        public Evenement(String filename, DateTime date, String name, Type type)
        {
            this.filename = filename;
            this.date = date;
            this.name = name;
            this.type = type;
            this.drivers = new BindingList<Driver>();
            for (int i = 1; i <= 500; i++)
                this.drivers.Add(new Driver(i, "(naam onbekend)", "(voertuig onbekend)"));
            this.entries = new BindingList<Entry>();
            for (int i = 1; i <= 500; i++)
                this.entries.Add(new Entry(this, 0, -1, 0));
            last = 0;
            Save();
        }

        public void Save()
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create(this.filename))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("evenement");
                    writer.WriteAttributeString("datum", this.date.ToString());
                    writer.WriteAttributeString("naam", this.name);
                    writer.WriteAttributeString("type", ((this.type == Type.SPRINT) ? "sprint" : "slalom"));
                    foreach (Driver d in this.drivers)
                    {
                        writer.WriteStartElement("deelnemer");
                        writer.WriteAttributeString("nummer", d.Number.ToString());
                        writer.WriteAttributeString("naam", d.Name);
                        writer.WriteAttributeString("voertuig", d.Vehicle);
                        writer.WriteEndElement();
                    }
                    foreach (Entry e in this.entries)
                        if(!((e.Number == -1) && (e.Stopwatch == 0) && (e.Value == 0)))
                        {
                            writer.WriteStartElement("tijd");
                            writer.WriteAttributeString("stopwatch", e.Stopwatch.ToString());
                            writer.WriteAttributeString("nummer", e.Number.ToString());
                            writer.WriteAttributeString("msec", e.Value.ToString());
                            writer.WriteEndElement();
                        }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
            }
            catch (Exception e)
            {
            }
        }

        public void Delete()
        {
            FileInfo fi = new FileInfo(filename);
            fi.Delete();
        }

        public override String ToString()
        {
            return date.ToString("D") + " " + name + " (" + ((type == Type.SLALOM)?"slalom":"sprint") + ")";
        }

        public void AppendTime(int stopwatch,int msec)
        {
            if (entries[last].Number == -1)
                entries[last] = new Entry(this, stopwatch, -1, msec);
            else
            {
                entries[last].Stopwatch = stopwatch;
                entries[last].Value = msec;
            }
            last++;
            Save();
        }

        public void RemoveRow(int n)
        {
            entries.Remove(entries[n]);
            entries.Add(new Entry(this, 0, -1, 0));
            if(last > 0)
                last--;
            Save();
        }

        public Driver FindDriver(int n)
        {
            foreach (Driver p in drivers)
                if (p.Number == n)
                    return p;
            return null;
        }

        public void CloneDrivers(BindingList<Driver> drivers)
        {
            this.drivers = new BindingList<Driver>();
            foreach (Driver driver in drivers)
                this.drivers.Add(new Driver(driver.Number, driver.Name, driver.Vehicle));
            Save();
        }

        public BindingList<Entry> Entries
        {
            get { return entries; }
        }

        public BindingList<Driver> Drivers
        {
            get { return drivers; }
        }

        public String Name
        {
            get { return name; }
        }

        public String Date
        {
            get { return date.ToString(); }
        }

        public int Last
        {
            get { return last; }
        }
    }
}
