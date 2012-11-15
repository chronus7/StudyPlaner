using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyPlaner
{
    [Flags]
    public enum GermanDay 
    { 
        Montag = 0,
        Dienstag = 1, 
        Mittwoch = 2, 
        Donnerstag = 3, 
        Freitag = 4, 
        Samstag = 5, 
        Sonntag = 6
    }

    public class Event
    {
        public Event(String parentID, string parentName, string parentShort)
        {
            this.ParentID = parentID;
            this.ParentName = parentName;
            this.ParentShort = parentShort;
        }

        public string ParentID { get; set; }
        public string ParentName { get; set; }
        public string ParentShort { get; set; }
        public string ID { get; set; }
        public string Type { get; set; }
        public GermanDay Day { get; set; }     
        public string Time { get; set; }   
        public string Location { get; set; }
        public int Importance { get; set; }
        public int Power { get; set; }
        
        public override string ToString()
        {
            //sgevent.ID.Split('_')[0] + " - " + sgevent.Day + ", " + sgevent.Time.Split(',')[0] + " bis " + sgevent.Time.Split(',')[1];
            string str = this.ID.Split('_')[0] + " - " + this.Day + ", ";
            str += this.Time.Split(',')[0] + " bis " + this.Time.Split(',')[1];
            return str;
        }
    }
}