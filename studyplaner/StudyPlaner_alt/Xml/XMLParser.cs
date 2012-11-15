using System;
using System.Xml;
using System.Collections.Generic;

namespace StudyPlaner
{
    public class XMLParser
    {
        public string _libpath;                 // path of libraries folder
        private string _usrsets;                // path of usersettings
        private XmlDocument _usersetsDoc;       // Xml loaded usersettings
        private List<XmlDocument> _libraries;   // List of Xml loaded libraries

        public XMLParser()
        {
            string standardpath = @"D:\Daten\Dropbox\Projekte\StudyPlaner\StudyPlaner\Xml\";

            _usrsets = standardpath + "usersettings.xml";
                                                                                // has to be changed to relative pathname
            
            _usersetsDoc = new XmlDocument();                                   // first time loading
            _usersetsDoc.Load(_usrsets);                                        // usersettings.xml

            if (_usersetsDoc["root"]["libraries"].HasAttribute("path"))
            {
                _libpath = _usersetsDoc["root"]["libraries"].Attributes["path"].Value;  // get libpath out of usersettings
            }
            else
            {
                _libpath = standardpath;
            }

            updateXML();
        }

        public void updateXML()
        {
            _usersetsDoc = new XmlDocument();
            _usersetsDoc.Load(_usrsets);
            loadLibraries();
        }

        // Creates a Module/Event with the data out of the XML //
        public Module getModule(string id)
        {
            foreach (XmlDocument doc in _libraries)
            {
                XmlElement modulexml = doc.GetElementById(id);

                if (modulexml != null)
                {
                    Module module = new Module(
                        modulexml.ParentNode.ParentNode.Attributes["id"].Value,             // uni
                        modulexml.ParentNode.Attributes["id"].Value);                       // region
                    module.ID = id;                                                         // id
                    module.Name = modulexml.Attributes["name"].Value;                       // name
                    module.Short = modulexml.Attributes["short"].Value;                      // short
                    module.Semester = modulexml.ChildNodes[0].InnerText;                    // semester

                    XmlNode bools = modulexml["bools"];
                    module.Lectures = Convert.ToInt32(bools["lectures"].InnerText);         // lectures (bool)
                    module.Exercises = Convert.ToInt32(bools["exercises"].InnerText);       // exercises (bool)
                    module.Tutorials = Convert.ToInt32(bools["tutorials"].InnerText);       // tutorials (bool)
                    module.Internships = Convert.ToInt32(bools["internships"].InnerText);   // internships (bool)

                    XmlNodeList events = modulexml.GetElementsByTagName("event");
                    module.Events = new List<Event>();
                    foreach (XmlNode eventxml in events)
                    {
                        module.Events.Add(getEvent(eventxml.Attributes["id"].Value));       // events
                    }

                    return module;
                }
            }
            return null;
        }

        public Event getEvent(string id)
        {
            foreach (XmlDocument doc in _libraries)
            {
                XmlElement eventxml = doc.GetElementById(id);

                if (eventxml != null)
                {
                    Event revent = new Event(eventxml.ParentNode.Attributes["id"].Value,                    // parent (id)
                        eventxml.ParentNode.Attributes["name"].Value,                                       // parent (name)
                        eventxml.ParentNode.Attributes["short"].Value);                                     // parent (short)
                    revent.Type = eventxml.Attributes["type"].Value;                                        // type
                    revent.ID = id;                                                                         // id
                    revent.Day = (GermanDay) Enum.Parse(typeof(GermanDay), eventxml["day"].InnerText);      // day
                    revent.Time = eventxml["time"].InnerText;                                               // time
                    revent.Location = eventxml["location"].InnerText;                                       // location
                    revent.Importance = Convert.ToInt32(eventxml["importance"].InnerText);                  // importance
                    revent.Power = Convert.ToInt32(eventxml["power"].InnerText);                            // power

                    return revent;
                }
            }
            return null;
        }

        // Writes the data of a Module/Event to the XML //
        public void writeModule(Module module)
        {
            foreach (XmlDocument doc in _libraries)
            {
                XmlElement uni = doc.GetElementById(module.Uni);

                if (uni != null)
                {
                    foreach (XmlNode region in uni.GetElementsByTagName("region"))
                    {
                        if (region.Attributes["id"].Value == module.Region)
                        {
                            // <module [...]>
                            XmlNode nodemodule = doc.CreateElement("module");

                            // <module id="_id_" [...]>
                            XmlAttribute moduleid = doc.CreateAttribute("id");
                            moduleid.Value = module.ID;
                            nodemodule.Attributes.Append(moduleid);

                            // <module name="_name_" [...]>
                            XmlAttribute modulename = doc.CreateAttribute("name");
                            modulename.InnerText = module.Name;
                            nodemodule.Attributes.Append(modulename);

                            // <module short="_short_" [...]>
                            XmlAttribute moduleshort = doc.CreateAttribute("short");
                            moduleshort.InnerText = module.Short;
                            nodemodule.Attributes.Append(moduleshort);

                            {
                                // <semester>_semester_</semester>
                                XmlNode subnodesem = doc.CreateElement("semester");
                                subnodesem.InnerText = module.Semester;
                                nodemodule.AppendChild(subnodesem);

                                // <bools>
                                XmlNode subnodebools = doc.CreateElement("bools");
                                {
                                    // <lectures></lectures>
                                    XmlNode subsubnodelectures = doc.CreateElement("lectures");
                                    subnodebools.AppendChild(subsubnodelectures);

                                    // <exercises></exercises>
                                    XmlNode subsubexercises = doc.CreateElement("exercises");
                                    subnodebools.AppendChild(subsubexercises);

                                    // <tutorials></tutorials>
                                    XmlNode subsubtutorials = doc.CreateElement("tutorials");
                                    subnodebools.AppendChild(subsubtutorials);

                                    // <internships></internships>
                                    XmlNode subsubinternships = doc.CreateElement("internships");
                                    subnodebools.AppendChild(subsubinternships);
                                }
                                // </bools>
                                nodemodule.AppendChild(subnodebools);

                                // <event [...]>[...]</event>
                                // has to be done afterwards, because of recursion.
                            }
                            // </module>
                            region.AppendChild(nodemodule);

                            // <event [...]>[...]</event>
                            if (module.Events != null)
                            {
                                foreach (Event ievent in module.Events)
                                {
                                    writeEvent(ievent);
                                }
                            }

                            saveLibDoc(doc);
                            updateBools(); 
                        }
                    }
                }
            }
        }

        public void writeEvent(Event mevent)
        {
            foreach (XmlDocument doc in _libraries)
            {
                XmlElement module = doc.GetElementById(mevent.ParentID);

                if (module != null)
                {
                    XmlNode nodeevent = doc.CreateElement("event");

                    // <event id="_id_" [..]>
                    XmlAttribute eventid = doc.CreateAttribute("id");
                    eventid.Value = mevent.ID;
                    nodeevent.Attributes.Append(eventid);

                    // <event type="_type_" [...]>
                    XmlAttribute eventtype = doc.CreateAttribute("type");
                    eventtype.Value = mevent.Type;
                    nodeevent.Attributes.Append(eventtype);

                    {
                        // <day>_day_</day>
                        XmlNode subnodeday = doc.CreateElement("day");
                        subnodeday.InnerText = mevent.Day.ToString();
                        nodeevent.AppendChild(subnodeday);

                        // <time>_time_</time>
                        XmlNode subnodetime = doc.CreateElement("time");
                        subnodetime.InnerText = mevent.Time;
                        nodeevent.AppendChild(subnodetime);

                        // <location>_loc_</location>
                        XmlNode subnodeloc = doc.CreateElement("location");
                        subnodeloc.InnerText = mevent.Location;
                        nodeevent.AppendChild(subnodeloc);

                        // <importance>_importance_</importance>
                        XmlNode subnodeimp = doc.CreateElement("importance");
                        subnodeimp.InnerText = mevent.Importance.ToString();
                        nodeevent.AppendChild(subnodeimp);

                        // <power>_power_</power>
                        XmlNode subnodepower = doc.CreateElement("power");
                        subnodepower.InnerText = mevent.Power.ToString();
                        nodeevent.AppendChild(subnodepower);
                    }

                    // <\event>
                    module.AppendChild(nodeevent);

                    saveLibDoc(doc);
                }
            }
        }

        public void updateModule(Module module)
        {
            foreach (XmlDocument doc in _libraries)
            {
                XmlElement xmlmodule = doc.GetElementById(module.ID);

                if (xmlmodule != null)
                {
                    xmlmodule.Attributes["name"].Value = module.Name;
                    xmlmodule.Attributes["short"].Value = module.Short;
                    xmlmodule["semester"].InnerText = module.Semester;
                    xmlmodule["bools"]["lectures"].InnerText = module.Lectures.ToString();
                    xmlmodule["bools"]["exercises"].InnerText = module.Exercises.ToString();
                    xmlmodule["bools"]["tutorials"].InnerText = module.Tutorials.ToString();
                    xmlmodule["bools"]["internships"].InnerText = module.Internships.ToString();

                    // events missing

                    saveLibDoc(doc);
                    updateBools();
                }
            }
        }

        // List of all Modules' names (of one uni)
        public List<Module> getAllModules(string uniID)
        {
            List<Module> list = new List<Module>();

            foreach (string modid in getModuleIds(uniID))
            {
                list.Add(getModule(modid));
            }

            return list;
        }

        // List of all Events of one type (of one Module)
        public List<Event> getAllEvents(Module module, string type)
        {
            List<Event> list = new List<Event>();

            foreach (Event sgevent in module.Events)
            {
                if (sgevent.Type == type)
                {
                    list.Add(sgevent);
                }
            }
            return list;
        }

        // List all selected Events
        public List<Event> getSelectedEvents()
        {
            XmlNodeList events = _usersetsDoc.GetElementsByTagName("event");
            List<Event> list = new List<Event>();

            foreach (XmlNode xevent in events)
            {
                list.Add(getEvent(xevent.InnerText));
            }

            return list;
        }

        // ===== Helpmethods ===== //

        private void saveLibDoc(XmlDocument doc)
        {
            doc.Save(_libpath + "Library_" + doc["uni"].Attributes["id"].Value + ".xml");
        }

        private List<XmlDocument> loadLibraries()
        {
            _libraries = new List<XmlDocument>();

            foreach (string id in getLibIds())
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(_libpath + "Library_" + id + ".xml");
                _libraries.Add(doc);
            }

            return _libraries;
        }

        private List<string> getLibIds()
        {
            List<string> ids = new List<string>();

            XmlNodeList unis = _usersetsDoc.GetElementsByTagName("uni");
            foreach (XmlNode uni in unis)
            {
                ids.Add(uni.Attributes["id"].Value);
            }
            
            return ids;
        }

        private List<string> getModuleIds(string uniID)
        {
            List<string> list = new List<string>();

            foreach (XmlDocument doc in _libraries)
            {
                XmlElement uni = doc.GetElementById(uniID);

                if (uni != null)
                {
                    foreach (XmlNode module in uni.GetElementsByTagName("module"))
                    {
                        list.Add(module.Attributes["id"].Value);
                    }
                }
            }

            return list;
        }

        private void updateBools()
        {
            foreach (XmlDocument doc in _libraries)
            {
                XmlNodeList modules = doc.GetElementsByTagName("module");

                if (modules != null)
                {
                    foreach (XmlElement module in modules)
                    {
                        int countlectures = 0;
                        int countexercises = 0;
                        int counttutorials = 0;
                        int countinternships = 0;

                        XmlNodeList events = module.GetElementsByTagName("event");

                        foreach (XmlNode xevent in events)
                        {
                            switch (xevent.Attributes["type"].Value)
                            {
                                case "lecture":
                                    countlectures++;
                                    break;
                                case "exercise":
                                    countexercises++;
                                    break;
                                case "tutorial":
                                    counttutorials++;
                                    break;
                                case "internship":
                                    countinternships++;
                                    break;
                            }
                        }

                        module["bools"]["lectures"].InnerText = countlectures.ToString();
                        module["bools"]["exercises"].InnerText = countexercises.ToString();
                        module["bools"]["tutorials"].InnerText = counttutorials.ToString();
                        module["bools"]["internships"].InnerText = countinternships.ToString();
                    }

                    saveLibDoc(doc);
                }
            }
        }
    }
}
