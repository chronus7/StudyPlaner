using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml.Schema;
using System;
using System.Xml;

namespace Studyplaner.UniversityStuff
{
    [XmlRoot(ElementName = "university")]
    public class University : IXmlSerializable
    {
        /// <summary>
        /// The (hopefully) unique id of the uni.
        /// </summary>
        public ushort ID { get; set; }

        /// <summary>
        /// The uni's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the uni's name.
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// The modules (as id's) of this uni.
        /// </summary>
        public List<uint> Modules { get; set; }

        public University()
        {
            Modules = new List<uint>();
        }

        public override string ToString()
        {
            return Name; // TODO | dj | only this?
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
            ID = ushort.Parse(reader.ReadElementString("id"));
            Name = reader.ReadElementString("name");
            ShortName = reader.ReadElementString("short");

            Modules = new List<uint>();
            reader.MoveToContent();
            XmlSerializer ser = new XmlSerializer(typeof(UniversityModule));
            while (reader.ReadToFollowing("module"))
            {
                XmlReader subreader = reader.ReadSubtree();
                subreader.Read();
                UniversityModule module = (UniversityModule)ser.Deserialize(subreader);
                subreader.Close();

                // TODO | dj | add module to lists...
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("id", ID.ToString());
            writer.WriteElementString("name", Name);
            writer.WriteElementString("short", ShortName);
            writer.WriteStartElement("modules");
            foreach (uint i in Modules)
                new XmlSerializer(typeof(UniversityModule)).Serialize(writer, UniversityManager.GetModule(i));
            //writer.WriteRaw(UniversityManager.GetModule(i)); //WriteElementString("moduleid", i.ToString());
            writer.WriteEndElement();
        }
    }
}
