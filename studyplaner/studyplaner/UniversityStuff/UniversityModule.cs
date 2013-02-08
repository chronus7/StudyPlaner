using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Studyplaner.UniversityStuff.Enums;
using System;

namespace Studyplaner.UniversityStuff
{
    [XmlRoot(ElementName="module")]
    public class UniversityModule : IXmlSerializable
    {
        /// <summary>
        /// The (hopefully) unique id of this module.
        /// </summary>
        public uint ID { get; set; }

        /// <summary>
        /// The name of this module.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The abbreviation of the module's name.
        /// </summary>
        public string ShortName { get; set; }
        
        /// <summary>
        /// The (hopefully) unique id of the
        /// module's parent uni.
        /// </summary>
        public ushort UniID
        {
            get
            {
                return UniversityFunctions.GetUniID(this.ID);
            }
            set
            {
                uint modID = ID % UniversityManager.MULTIPLYER_UNIVERSITY;
                ID = modID + (uint)(value * UniversityManager.MULTIPLYER_UNIVERSITY);
                // TODO | dj | fun. if changing uniID here we will have to refresh the Dictonary in UniversityManager
            }
        }
        
        /// <summary>
        /// The semester, the module is available.
        /// </summary>
        public Semester Semester { get; set; }
        
        /// <summary>
        /// The department 'hosting' this module.
        /// </summary>
        public Department Department { get; set; }
        
        /// <summary>
        /// The list of all event of this module.
        /// </summary>
        public List<ulong> Events { get; set; }

        public UniversityModule()
        {
            Events = new List<ulong>();
        }

        //-- IXmlSerializable --\\

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            reader.ReadStartElement();
            ID = uint.Parse(reader.ReadElementString("id"));
            Name = reader.ReadElementString("name");
            ShortName = reader.ReadElementString("short");
            Semester = (Semester)Enum.Parse(typeof(Semester), reader.ReadElementString("semester"));
            Department = (Department)Enum.Parse(typeof(Department), reader.ReadElementString("department"));

            Events = new List<ulong>(); // TODO
            reader.MoveToContent();
            XmlSerializer ser = new XmlSerializer(typeof(UniversityEvent));
            while (reader.ReadToFollowing("event"))
            {
                XmlReader subreader = reader.ReadSubtree();
                subreader.Read();
                UniversityEvent ev = (UniversityEvent)ser.Deserialize(subreader);
                subreader.Close();

                // TODO | dj | add to list...
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("id", ID.ToString());
            writer.WriteElementString("name", Name);
            writer.WriteElementString("short", ShortName);
            writer.WriteElementString("semester", Semester.ToString());
            writer.WriteElementString("department", Department.ToString());
            writer.WriteStartElement("events");
            foreach (ulong ev in Events)
                new XmlSerializer(typeof(UniversityEvent)).Serialize(writer, UniversityManager.GetEvent(ev));
            writer.WriteEndElement();
        }
    }
}
