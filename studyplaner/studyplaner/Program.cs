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
            UniLibrary ul2 = new UniLibrary();
            ul2.ID = 1111;
            Console.Out.WriteLine("Lib: " + ul.ID);
            Console.Out.WriteLine("Lib: " + ul2.ID);
            Libraries libs = new Libraries(new List<UniLibrary> { ul, ul2 });

            string filename = @"..\..\Data\Libs.xml"; // noooo....
            XmlParser<Libraries>.Serialize(filename, libs);
            Console.WriteLine("Original [0]: " + libs[0].ID);
            Console.WriteLine("Original [1]: " + libs[1].ID);

            Libraries libraries = XmlParser<Libraries>.Deserialize(filename);
            Console.WriteLine("The read [0]: " + libraries[0].ID);
            Console.WriteLine("The read [1]: " + libraries[1].ID);
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

            string filename = @"..\..\Data\uniLib_" + lib.ID + ".xml"; // nooooooo....
            XmlParser<UniLibrary>.Serialize(filename, lib);
            Console.WriteLine("Original Library: " + lib.ID);

            UniLibrary library = XmlParser<UniLibrary>.Deserialize(filename);
            Console.WriteLine("The read Library: " + library.ID + " " + library.Modules);
        }
    }
}
