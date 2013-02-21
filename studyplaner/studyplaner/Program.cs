using System;
using System.Windows.Forms;
using Studyplaner.GUI.Forms;
using System.Runtime.InteropServices;
using Studyplaner.UniversityStuff;
using System.Collections.Generic;

namespace Studyplaner
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartUp();
            Application.Run(new MainForm());
            //Application.Run(new EditUniModuleForm(11100001));
            //mockupSerialization();
        }

        private static void StartUp()
        {
            Logging.LoggingManager.Initialize();
            UniversityManager.Initialize();
        }

        private static void mockupSerialization()
        {
            //UniversityManager.Initialize();

            //University uni = new University();
            //uni.ID = 111;
            //uni.Name = "Uni Hamburg";
            //uni.ShortName = "UHH";
            //UniversityManager.AddUniversity(uni);

            //UniversityModule mod1 = new UniversityModule();
            //mod1.Name = "TestModule1";
            //mod1.ShortName = "TM1";
            //uint mod1id = UniversityManager.AddModule(111, mod1);

            //UniversityEvent ev1 = new UniversityEvent();
            //ev1.LVNum = "64-001";
            //UniversityManager.AddEvent(mod1id, ev1);

            //UniversityModule mod2 = new UniversityModule();
            //mod2.Name = "Test Module 2";
            //mod2.ShortName = "TM2";
            //UniversityManager.AddModule(111, mod2);

            //string s = "{ ";
            //string s2 = "{ ";
            //foreach (uint i in UniversityManager.GetUniversity(111).Modules)
            //{
            //    s += i + ", ";
            //    foreach (ulong e in UniversityManager.GetModule(i).Events)
            //        s2 += UniversityManager.GetEvent(e).ID + ", ";
            //}
            //Console.Out.WriteLine("Initialized uni: " + uni.ID + "\n" +
            //    "| it's modules: " + s.Substring(0, s.Length - 2) + " }\n" +
            //    "| it's events: " + s2.Substring(0, s2.Length - 2) + " }");

            //// serialize:
            //Xml.XmlSerializer<University>.Serialize(@"..\..\Data\university_111.xml", uni);
            
            // deserialize:
            UniversityManager.Initialize(); // important!

            string s = "{ ";
            string s2 = "{ ";
            foreach (uint i in UniversityManager.GetUniversity(111).Modules)
            {
                s += i + ", ";
                foreach (ulong e in UniversityManager.GetModule(i).Events)
                    s2 += e + ", ";
            }
            Console.Out.WriteLine("Deserialized uni: " + 111 + "\n" +
                "| it's modules: " + s.Substring(0, s.Length - 2) + " }\n" + 
                "| it's events: " + s2.Substring(0, s2.Length - 2) + " }");

            ////change and serialize
            //UniversityManager.GetModule(11100001).Semester = UniversityStuff.Enums.Semester.Summer;
            //UniversityManager.StoreUniversity(111);
            //UniversityManager.Initialize();
            //Console.WriteLine(UniversityManager.GetModule(11100001).Semester);
        }

        private static UniversityModule mockupEditModuleForm()
        {
            UniversityModule mod = new UniversityModule();
            mod.Name = "Algorithmen und Datenstrukturen";
            mod.ShortName = "AD";
            mod.Semester = UniversityStuff.Enums.Semester.Winter;
            mod.Department = UniversityStuff.Enums.Department.IT;
            mod.ID = 12354;
            
            UniversityEvent ev = new UniversityEvent();
            ev.LVNum = "67-125";
            ev.Type = UniversityStuff.Enums.EventType.Lecture;
            ev.Date = new Various.Time(8, 15, new DateTime(2012, 12, 4));
            ev.Duration = new TimeSpan(1, 30, 0);
            //mod.Events.Add(ev);

            UniversityEvent ev2 = new UniversityEvent();
            ev2.LVNum = "67-126";
            ev2.Type = UniversityStuff.Enums.EventType.Internship;
            ev2.Date = new Various.Time(10, 15, new DateTime(2012, 12, 4));
            ev2.Duration = new TimeSpan(1, 30, 0);
            //mod.Events.Add(ev2);

            UniversityEvent ev3 = new UniversityEvent();
            ev3.LVNum = "67-127";
            ev3.Type = UniversityStuff.Enums.EventType.Internship;
            ev3.Date = new Various.Time(12, 15, new DateTime(2012, 12, 4));
            ev3.Duration = new TimeSpan(1, 30, 0);
            //mod.Events.Add(ev3);

            return mod;
        }
    }
}
