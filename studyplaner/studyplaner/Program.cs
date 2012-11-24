using System;
using System.Windows.Forms;
using Studyplaner.Materials.Uni;
using Studyplaner.Services.Xml;
using System.Collections.Generic;
using Studyplaner.Materials;

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
            //Application.Run(new MainForm());
            //Console.WriteLine(Time.ValueOf("23:59"));//to test time :P
            SerializationDummy();
            SerializationDummy2();
        }

        private static void SerializationDummy2()
        {
            UniLibrary ul = new UniLibrary();
            ul.ID = 1231;
            Console.Out.WriteLine("Lib: " + ul.ID);
            Libraries libs = new Libraries(new List<UniLibrary> { ul });
            //Serialization
        }

        static void SerializationDummy()
        {
            UniEvent ev = new UniEvent();
            ev.ID = 123546;
            ev.LVNum = "64-001";
            ev.ModuleID = 1245;
            ev.Location = "somewhere";
            ev.Lecturer = "somebody";
            ev.Power = false;
            ev.Importance = 5;
            ev.Date = new Values.Time(10, 15, Enums.WeekInterval.EveryWeek);
            ev.Duration = new TimeSpan(1, 30, 0);

            UniModule mo = new UniModule();
            mo.ID = 1245;
            mo.Events = new List<UniEvent>() { ev };
            mo.Name = "testModule";
            mo.Semester = Enums.Semester.Winter;
            mo.Short = "tM";
            mo.Department = Enums.Department.IT;
            mo.UniID = 1111;

            UniLibrary lib = new UniLibrary();
            lib.ID = 1111;
            lib.Name = "Uni HH";
            lib.Short = "UHH";
            lib.Modules = new List<UniModule>() { mo };

            string filename = @"test.xml"; // is in debug dir -.-'
            XmlParser.Serialize(filename, lib);
            Console.WriteLine("Original Library: " + lib.ID);

            UniLibrary library = XmlParser.Deserialize(filename);
            Console.WriteLine("The read Library: " + library.ID + " " + library.Modules);
        }
    }
}
