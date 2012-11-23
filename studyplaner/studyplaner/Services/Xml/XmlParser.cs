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
    public class XmlParser
    {
        public static void Serialize(string filename, UniLibrary uniLibrary)
        {
            XmlSerializer ser = new XmlSerializer(typeof(UniLibrary));
            TextWriter tw = null;
            try
            {
                if (!File.Exists(filename))
                {
                    File.Create(filename);
                    Console.WriteLine("Created file: " + filename);
                }

                tw = new StreamWriter(filename);

                ser.Serialize(tw, uniLibrary);
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

        public static UniLibrary Deserialize(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(UniLibrary));
            // -- to handle incorrect Input --
            //ser.UnknownNode += new XmlNodeEventHandler(XmlSerializer_UnknownNode);
            //ser.UnknownAttribute +=
            FileStream fs = null;
            UniLibrary lib = null;
            try
            {
                fs = new FileStream(filename, FileMode.Open);
                lib = (UniLibrary)ser.Deserialize(fs);
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
            return lib;
        }
    }
}
