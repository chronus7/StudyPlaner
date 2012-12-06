using System.Collections.Generic;
using System.Xml.Serialization;
using Studyplaner.UniversityStuff;

namespace Studyplaner.UniversityStuff
{
    [XmlRootAttribute(ElementName="module")]
    public class UniversityModule
    {
        /// <summary>
        /// The (hopefully) unique id of this module.
        /// </summary>
        [XmlElement(ElementName="id")]
        public int ID { get; set; }

        /// <summary>
        /// The name of this module.
        /// </summary>
        [XmlElement(ElementName="name")]
        public string Name { get; set; }
        
        /// <summary>
        /// The abbreviation of the module's name.
        /// </summary>
        [XmlElement(ElementName="short")]
        public string Short { get; set; }
        
        /// <summary>
        /// The (hopefully) unique id of the
        /// module's parent uni.
        /// </summary>
        [XmlIgnore]
        public int UniID { get; set; }
        
        /// <summary>
        /// The semester, the module is available.
        /// </summary>
        [XmlElement(ElementName="semester")]
        public Semester Semester { get; set; }
        
        /// <summary>
        /// The department 'hosting' this module.
        /// </summary>
        [XmlElement(ElementName="department")]
        public Department Department { get; set; }
        
        /// <summary>
        /// The list of all event of this module.
        /// </summary>
        [XmlArray(ElementName="events")]
        [XmlArrayItem(ElementName="event")]
        public List<UniversityEvent> Events { get; set; }

        public UniversityModule()
        {
            Events = new List<UniversityEvent>();
        }
    }
}
