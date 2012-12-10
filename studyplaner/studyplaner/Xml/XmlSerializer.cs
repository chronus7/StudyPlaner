using System;
using System.IO;
using System.Xml.Serialization;

namespace Studyplaner.Xml
{
    /// <summary>
    /// Parses the Xml which contains
    /// important data.
    /// </summary>
    public class XmlSerializer<T>
    {
        /// <summary>
        /// Serializes the given Object in the named file.
        /// </summary>
        /// <param name="filename">Path to the file.</param>
        /// <param name="Object">The object which will be serialized.</param>
        public static void Serialize(string filename, T Object)
        {
            XmlSerializer xSer = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                try
                {
                    xSer.Serialize(fs, Object);
                }
                catch (IOException ioEx)
                {
                    throw new IOException("There was an error during serialization of the given " + typeof(T), ioEx);
                }
            }
        }

        /// <summary>
        /// Deserializes T from the named file.
        /// </summary>
        /// <param name="filename">Path to the file.</param>
        /// <returns>The deserialized object.</returns>
        public static T Deserialize(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            // -- to handle incorrect Input -- TODO | dj | handle incorrect nodes.
            //ser.UnknownNode += new XmlNodeEventHandler(XmlSerializer_UnknownNode);
            //ser.UnknownAttribute +=

            T value = default(T);
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    value = (T)ser.Deserialize(fs);
                }
                catch (IOException ioEx)
                {
                    throw new IOException("There was an error during deserialization of the given file " + filename, ioEx);
                }      
            }
            return value;
        }
    }
}
