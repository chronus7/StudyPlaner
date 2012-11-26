using Studyplaner.Materials.Uni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Studyplaner.Materials
{
    [XmlRoot(ElementName="libraries")]
    public class Libraries : IXmlSerializable
    {
        private List<UniLibrary> _list;

        public Libraries()
        {
            _list = new List<UniLibrary>();
        }

        public Libraries(List<UniLibrary> list)
        {
            _list = list;
        }

        public void Add(UniLibrary uniLib)
        {
            _list.Add(uniLib);
        }

        public void Remove(UniLibrary uniLib)
        {
            _list.Remove(uniLib);
        }

        public void Remove(int index)
        {
            _list.RemoveAt(index);
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

        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            reader.ReadStartElement();
            while (reader.ReadToFollowing("uni"))
            {
                XmlReader r = reader.ReadSubtree();
                string id = r.ReadElementString("id");
                string path = r.ReadElementString("path");

                UniLibrary ul = new UniLibrary();
                ul.ID = int.Parse(id);
                // TODO more!!!
                _list.Add(ul);
            }
            //TODO does this work???
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
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
