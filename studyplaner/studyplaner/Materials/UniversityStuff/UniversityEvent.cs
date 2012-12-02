using System;
using System.Xml.Serialization;
using Studyplaner.Enums;
using Studyplaner.Values;
using System.ComponentModel;

namespace Studyplaner.Materials.UniversityStuff
{
    [XmlRootAttribute("event")]
    public class UniversityEvent
    {
        /// <summary>
        /// The (hopefully) unique ID of the event.
        /// </summary>
        [XmlElement(ElementName="id")]
        public int ID { get; set; }
        
        /// <summary>
        /// The (hopefully) unique ID of the event's
        /// parent module.
        /// </summary>
        [XmlIgnore]
        public int ModuleID { get; set; }
        
        /// <summary>
        /// The LV-Number of the event.
        /// </summary>
        [XmlElement(ElementName = "lvnum")]
        public string LVNum { get; set; }
        
        /// <summary>
        /// The docation, where the event takes place.
        /// </summary>
        [XmlElement(ElementName = "location")]
        public string Location { get; set; }
        
        /// <summary>
        /// The time/date, when the event starts.
        /// </summary>
        [XmlElement(ElementName = "date")]
        public Time Date { get; set; }
        
        /// <summary>
        /// The duration of the event.
        /// </summary>
        [XmlIgnore]
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// DO NOT USE THIS. IT JUST FOR SERIALIZATION!
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)] // <-- seems not to work
        [XmlElement(ElementName = "duration")]
        public string DurationSerialize
        {
            get { return Duration.ToString(); }
            set { Duration = TimeSpan.Parse(value); }
        }
        
        /// <summary>
        /// The persons, standing at the front.
        /// </summary>
        [XmlElement(ElementName = "lecturer")]
        public string Lecturer { get; set; }
        
        /// <summary>
        /// The importance of this event.
        /// Mainly for notifications.
        /// </summary>
        [XmlElement(ElementName = "importance")]
        public byte Importance { get; set; }
        
        /// <summary>
        /// Wether the location, the event takes place,
        /// has a reachable power-plug or not.
        /// </summary>
        [XmlElement(ElementName = "power")]
        public bool Power { get; set; }

        /// <summary>
        /// The type of this event.
        /// </summary>
        [XmlElement(ElementName = "type")]
        public EventType Type { get; set; }
    }
}
