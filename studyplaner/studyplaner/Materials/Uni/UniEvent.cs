using System;
using System.Xml.Serialization;
using Studyplaner.Enums;
using Studyplaner.Values;
using System.ComponentModel;

namespace Studyplaner.Materials.Uni
{
    [XmlRootAttribute("event")]
    public class UniEvent
    {
        [XmlElement(ElementName="id")]
        public int ID { get; set; }
        [XmlIgnore]
        public int ModuleID { get; set; }
        [XmlElement(ElementName = "lvnum")]
        public string LVNum { get; set; }
        [XmlElement(ElementName = "location")]
        public string Location { get; set; }
        [XmlElement(ElementName = "date")]
        public Time Date { get; set; }
        [XmlIgnore]
        public TimeSpan Duration { get; set; }
        [XmlElement(ElementName = "lecturer")]
        public string Lecturer { get; set; }
        [XmlElement(ElementName = "importance")]
        public byte Importance { get; set; }
        [XmlElement(ElementName = "power")]
        public bool Power { get; set; }
        [XmlElement(ElementName = "type")]
        public EventType Type { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)] // <-- seems not to work
        [XmlElement(ElementName = "duration")]
        public long DurationTicks
        {
            get { return Duration.Ticks; }
            set { Duration = new TimeSpan(value); }
        }
    }
}
