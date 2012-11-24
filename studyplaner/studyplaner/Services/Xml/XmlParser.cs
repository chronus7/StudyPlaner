using System;
using System.IO;
using System.Xml.Serialization;
using Studyplaner.Materials.Uni;

namespace Studyplaner.Services.Xml
{
    /// <summary>
    /// Parses the Xml which contains
    /// important data.
    /// </summary>
    public class XmlParser<T>
    {
        /// <summary>
        /// Serializes the given Object in the named file.
        /// </summary>
        /// <param name="filename">Path to the file.</param>
        /// <param name="Object">The object which will be serialized.</param>
        public static void Serialize(string filename, T Object)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            TextWriter tw = null;
            try
            {
                if (!File.Exists(filename))
                {
                    File.Create(filename);
                    Console.WriteLine("Created file: " + filename);
                }

                tw = new StreamWriter(filename);

                ser.Serialize(tw, Object);
                tw.Flush();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (tw != null)
                    tw.Close();
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
            // -- to handle incorrect Input --
            //ser.UnknownNode += new XmlNodeEventHandler(XmlSerializer_UnknownNode);
            //ser.UnknownAttribute +=
            FileStream fs = null;
            T ob = default(T);
            try
            {
                fs = new FileStream(filename, FileMode.Open);
                ob = (T)ser.Deserialize(fs);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            return ob;
        }
    }
}
