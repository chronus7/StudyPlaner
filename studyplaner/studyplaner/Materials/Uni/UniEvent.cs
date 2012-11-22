using System;
using System.Xml.Serialization;
using Studyplaner.Enums;
using Studyplaner.Values;

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
        [XmlElement(ElementName="duration")]
        public TimeSpan Duration { get; set; }
        [XmlElement(ElementName = "lecturer")]
        public string Lecturer { get; set; }
        [XmlElement(ElementName = "importance")]
        public byte Importance { get; set; }
        [XmlElement(ElementName = "power")]
        public bool Power { get; set; }
        [XmlElement(ElementName = "type")]
        public EventType Type { get; set; }
    }
}
