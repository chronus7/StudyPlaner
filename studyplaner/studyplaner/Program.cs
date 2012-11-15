using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Studyplaner.GUI;

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
            //Console.WriteLine("Let's check wether mine does everysthing good as well :P");
        }
    }
}
