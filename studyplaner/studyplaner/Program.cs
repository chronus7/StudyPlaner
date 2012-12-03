using System;
using System.Windows.Forms;
using Studyplaner.GUI.Forms;
using Studyplaner.Materials.UniversityStuff;

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
            Application.Run(new EditUniModuleForm(mockup()));
        }

        private static UniversityModule mockup()
        {
            UniversityModule mod = new UniversityModule();
            mod.Name = "Algorithmen und Datenstrukturen";
            mod.Short = "AD";
            mod.Semester = Enums.Semester.Winter;
            mod.Department = Enums.Department.IT;
            mod.ID = 12354;
            
            UniversityEvent ev = new UniversityEvent();
            ev.LVNum = "67-125";
            ev.Type = Enums.EventType.Lecture;
            mod.Events.Add(ev);

            UniversityEvent ev2 = new UniversityEvent();
            ev2.LVNum = "67-126";
            ev2.Type = Enums.EventType.Internship;
            mod.Events.Add(ev2);

            UniversityEvent ev3 = new UniversityEvent();
            ev3.LVNum = "67-127";
            ev3.Type = Enums.EventType.Internship;
            mod.Events.Add(ev3);

            return mod;
        }
    }
}
