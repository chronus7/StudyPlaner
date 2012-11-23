﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Studyplaner.Materials.Uni
{
    [XmlRootAttribute(ElementName="library")]
    public class UniLibrary
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
        public string Short { get; set; }

        /// <summary>
        /// The modules of this uni.
        /// </summary>
        [XmlArray(ElementName="modules")]
        [XmlArrayItem(ElementName="module")]
        public List<UniModule> Modules { get; set; }
    }
}
