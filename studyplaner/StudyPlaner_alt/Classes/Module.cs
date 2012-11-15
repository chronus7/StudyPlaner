using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace StudyPlaner
{
    public class Module
    {
        public Module()
        {

        }
        public Module(string uniID, string region)
        {
            this.Uni = uniID;
            this.Region = region;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Short { get; set; }
        public string Semester { get; set; }
        public string Uni { get; set; }
        public string Region { get; set; }

        public int Lectures { get; set; }
        public int Exercises { get; set; }
        public int Tutorials { get; set; }
        public int Internships { get; set; }

        public List<Event> Events { get; set; }

        public List<Event> EventsOfType(string type)
        {
            List<Event> list = new List<Event>();

            if (Events != null)
            {
                foreach (Event mevent in Events)
                {
                    if (mevent.Type == type)
                    {
                        list.Add(mevent);
                    }
                }

                return list;
            }
            return null;
        }

        public override string ToString()
        {
            return (this.ID + " - " + this.Name);
        }
    }
}
