using System;
using System.IO;
using System.Xml.Serialization;
using Studyplaner.Materials.Uni;

namespace Studyplaner.Services.Xml
{
    /// <summary>
    /// Parses the Xml which contains
    /// important data.
    /// 
    /// We should decide how we build up
    /// the arcitecture!!! :P
    /// </summary>
    public class XmlParser
    {
        public static void Serialize(string filename, UniEvent uniEvent)
        {
            XmlSerializer ser = new XmlSerializer(typeof(UniEvent));
            TextWriter tw = null;
            try
            {
                if (!File.Exists(filename))
                {
                    File.Create(filename);
                    Console.WriteLine("Created file: " + filename);
                }

                tw = new StreamWriter(filename);

                ser.Serialize(tw, uniEvent);
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

        public static UniEvent DeSerialize(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(UniEvent));
            // -- to handle incorrect Input --
            //ser.UnknownNode += new XmlNodeEventHandler(XmlSerializer_UnknownNode);
            //ser.UnknownAttribute +=
            FileStream fs = null;
            UniEvent ev = null;
            try
            {
                fs = new FileStream(filename, FileMode.Open);
                ev = (UniEvent)ser.Deserialize(fs);
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
            return ev;
        }
    }
}
