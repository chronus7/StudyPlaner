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
        public static void Serialize(string filename, UniModule uniModule)
        {
            XmlSerializer ser = new XmlSerializer(typeof(UniModule));
            TextWriter tw = null;
            try
            {
                if (!File.Exists(filename))
                {
                    File.Create(filename);
                    Console.WriteLine("Created file: " + filename);
                }

                tw = new StreamWriter(filename);

                ser.Serialize(tw, uniModule);
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

        public static UniModule DeSerialize(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(UniModule));
            // -- to handle incorrect Input --
            //ser.UnknownNode += new XmlNodeEventHandler(XmlSerializer_UnknownNode);
            //ser.UnknownAttribute +=
            FileStream fs = null;
            UniModule mo = null;
            try
            {
                fs = new FileStream(filename, FileMode.Open);
                mo = (UniModule)ser.Deserialize(fs);
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
            return mo;
        }
    }
}
