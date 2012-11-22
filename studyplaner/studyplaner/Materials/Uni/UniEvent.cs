using System;
using Studyplaner.Enums;
using Studyplaner.Values;
using System.Xml.Serialization;

namespace Studyplaner.Materials.Uni
{
    [XmlRootAttribute("event")]
    public class UniEvent
    {
        public int ID { get; set; }
        public int ModuleID { get; set; }
        public string LVNum { get; set; }
        public string Location { get; set; }
        [XmlIgnore]
        public Time Date { get; set; }
        [XmlIgnore]
        public TimeSpan Duration { get; set; }
        public string Lecturer { get; set; }
        public byte Importance { get; set; }
        public bool Power { get; set; }
        public EventType Type { get; set; }
    }
}
