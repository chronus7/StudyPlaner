using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Studyplaner.GUI.Forms;
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
            Application.Run(new MainForm());
            //Console.WriteLine(Time.ValueOf("23:59"));//to test time :P
        }
    }
}
