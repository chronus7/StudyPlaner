using System;
using System.Windows.Forms;
using Studyplaner.Materials.Uni;
using Studyplaner.Services.Xml;

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
            UniEvent ev = new UniEvent();
            ev.ID = 123546;
            ev.LVNum = "64-001";
            ev.ModuleID = 1245;
            ev.Location = "somewhere";
            ev.Lecturer = "somebody";
            ev.Power = false;
            ev.Importance = 5;
            //...
            string filename = @"test.xml"; // is in debug dir -.-'
            XmlParser.Serialize(filename, ev);
            Console.WriteLine("Original Event: " + ev.ID);
            UniEvent ev2 = XmlParser.DeSerialize(filename);
            Console.WriteLine("The read Event: " + ev.ID);
        }
    }
}
