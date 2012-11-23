using Studyplaner.Materials.Uni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Studyplaner.Materials
{
    public class Libraries : IXmlSerializable
    {
        private List<UniLibrary> _list;

        public Libraries(List<UniLibrary> list)
        {
            _list = list;
        }

        public UniLibrary this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }//TODO | dj | maybe also file adding etc.
        }

        public IEnumerator<UniLibrary> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            reader.MoveToContent();
            reader.ReadStartElement();
            //TODO how?!?!
            reader.ReadEndElement();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            foreach (UniLibrary lib in _list)
            {
                writer.WriteStartElement("uni");
                writer.WriteElementString("id", lib.ID.ToString());
                writer.WriteElementString("path", @"data/uniLib_" + lib.ID + ".xml");
                writer.WriteEndElement();//???
            }
        }
    }
}
