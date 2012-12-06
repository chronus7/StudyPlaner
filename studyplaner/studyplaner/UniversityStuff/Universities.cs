using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using Studyplaner.Services.Xml;

namespace Studyplaner.UniversityStuff
{
    [Obsolete]
    [XmlRoot(ElementName="universities")]
    public class Universities : IXmlSerializable
    {
        private List<University> _list;

        public Universities()
        {
            _list = new List<University>();
        }

        public Universities(List<University> list)
        {
            _list = list;
        }

        public void Add(University uniLib)
        {
            _list.Add(uniLib);
        }

        public void Remove(University uniLib)
        {
            _list.Remove(uniLib);
        }

        public void Remove(int index)
        {
            _list.RemoveAt(index);
        }

        public University this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }//TODO | dj | maybe also file adding etc.
        }

        public IEnumerator<University> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            reader.ReadStartElement();
            while (reader.Name.Equals("university"))
            {
                reader.ReadStartElement();
                string id = reader.ReadElementString("id");
                reader.ReadEndElement();

                String path = @"..\..\Data\university_" + id + ".xml"; //TODO | dj | change to userchosen path
                University ul = XmlSerializer<University>.Deserialize(path);
                Console.Out.WriteLine(ul.ID);
                _list.Add(ul);
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (University uni in _list)
            {
                writer.WriteStartElement("university");
                writer.WriteElementString("id", uni.ID.ToString());
                writer.WriteEndElement();
            }
        }
    }
}
