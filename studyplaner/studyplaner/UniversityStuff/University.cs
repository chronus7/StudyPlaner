using System.Collections.Generic;
using System.Xml.Serialization;

namespace Studyplaner.UniversityStuff
{
    [XmlRootAttribute(ElementName="university")]
    public class University
    {
        /// <summary>
        /// The (hopefully) unique id of the uni.
        /// </summary>
        [XmlElement(ElementName="id")]
        public int ID { get; set; }

        /// <summary>
        /// The uni's name.
        /// </summary>
        [XmlElement(ElementName="name")]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the uni's name.
        /// </summary>
        [XmlElement(ElementName="short")]
        public string ShortName { get; set; }

        /// <summary>
        /// The modules of this uni.
        /// </summary>
        [XmlArray(ElementName="modules")]
        [XmlArrayItem(ElementName="module")]
        public List<UniversityModule> Modules { get; set; }
    }
}
